using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace Ini2Flame
{
    public partial class EditDBForm : Form
    {
        private FRParser frp;
        DataTable table;
        int ileDragEnter = 0;
        int ileDragOver = 0;
        Dictionary<TreeNode, XmlNode> dictSerwers = new Dictionary<TreeNode, XmlNode>();
        Dictionary<TreeNode, XmlNode> dictDatabases = new Dictionary<TreeNode, XmlNode>();

        public EditDBForm(FRParser afrp)
        {
            InitializeComponent();
            frp = afrp;
            Init();
        }

        private void Init()
        {
            int i = 0;
            int j = 0;
            TreeNode dbTreeNode = null;
            TreeNode srvTreeNode = null;
            foreach (XmlNode node in frp.root.ChildNodes)            
                if (node.Name == "server")                
                    foreach (XmlNode innerSrvNode in node.ChildNodes)
                    {
                        if (innerSrvNode.Name == "name")
                        {
                            srvTreeNode = tree.Nodes.Add(i.ToString(), innerSrvNode.InnerText);
                            dictSerwers.Add(srvTreeNode, node);
                            i++;
                        }                    
                        if (innerSrvNode.Name == "database")                       
                            foreach (XmlNode innerDBNode in innerSrvNode.ChildNodes)
                            {
                                if (innerDBNode.Name == "name")
                                {
                                    dbTreeNode = srvTreeNode.Nodes.Add(j.ToString(), innerDBNode.InnerText);
                                    dictDatabases.Add(dbTreeNode, innerSrvNode);
                                    j++;
                                }
                            
                            }                        
                    }                                         
            tree.ExpandAll();
            InitGrid();
        }

        private void InitGrid()
        {

            table = new DataTable();
            table.Columns.Add("col1");

            BindingSource bs = new BindingSource();
            bs.DataSource = table;

            grid.DataSource = bs;
            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            /*grid.DataSource = bs;*/

            //grid.ColumnCount = 1;
            //grid.ColumnHeadersVisible = true;
            //grid.Columns[0].Name = "Recipe";
            //grid.Rows.Add("five");
            //grid.Rows.Insert("0");
        }

        private void tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

            ileDragEnter++;
            DragInfo(e);
        }

        private void tree_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tree.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = tree.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Confirm that the node at the drop location is not 
            // the dragged node and that target node isn't null
            // (for example if you drag outside the control)
            if (!draggedNode.Equals(targetNode) && targetNode != null && !IsParent(draggedNode, targetNode))
            {
                // Remove the node from its current 
                // location and add it to the node at the drop location.
                if (InsertAsSubNode(targetNode, targetPoint))
                {
                    if (dictSerwers.Keys.Contains(targetNode) && dictDatabases.Keys.Contains(draggedNode))
                    {
                        draggedNode.Remove();
                        targetNode.Nodes.Add(draggedNode);
                        dictDatabases[draggedNode].ParentNode.RemoveChild(dictDatabases[draggedNode]);
                        dictSerwers[targetNode].AppendChild(dictDatabases[draggedNode]);
                    }
                }
                else
                {
                    if (dictDatabases.Keys.Contains(targetNode) && dictDatabases.Keys.Contains(draggedNode))
                    {
                        draggedNode.Remove();
                        targetNode.Parent.Nodes.Insert(targetNode.Index + 1, draggedNode);
                        dictDatabases[draggedNode].ParentNode.RemoveChild(dictDatabases[draggedNode]);
                        dictDatabases[targetNode].ParentNode.InsertAfter(dictDatabases[draggedNode], dictDatabases[targetNode]);
                    }
                }               
                // Expand the node at the location 
                // to show the dropped node.
                targetNode.Expand();
            }
        }

        private bool IsParent(TreeNode adraggedNode, TreeNode atargetNode)
        {
            if (atargetNode == null)
                return false;
            return (adraggedNode == atargetNode.Parent) || IsParent(adraggedNode, atargetNode.Parent);
        }

        private bool InsertAsSubNode(TreeNode atargetNode, Point atreeViewPoint)
        {
            bool result = 12 + (atargetNode.Level) * (19 + 10 + 10) < atreeViewPoint.X;
            if (result)
                Cursor.Current = Cursors.PanEast;
            else
                Cursor.Current = Cursors.PanSouth;
            return result;
        }

        private void DragInfo(DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tree.PointToClient(new Point(e.X, e.Y));
            // Retrieve the node at the drop location.
            TreeNode targetNode = tree.GetNodeAt(targetPoint);
            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            table.Rows.Clear();
            table.Rows.Add("Enter: " + ileDragEnter.ToString());
            //table.Rows.Add("Over: " + ileDragOver.ToString());
            table.Rows.Add("e: (" + e.X.ToString() + "," + e.Y.ToString() + ")");
            if (targetPoint != null)
                table.Rows.Add("targetPoint: (" + targetPoint.X.ToString() + "," + targetPoint.Y.ToString() + ")");
            if (targetNode != null)
            {
                table.Rows.Add("targetNode lvl: " + targetNode.Level.ToString());
                table.Rows.Add("targetNode key: " + targetNode. ToString());
            }
            if (draggedNode != null)
            {
                table.Rows.Add("draggedNode lvl: " + draggedNode.Level.ToString());
            }
            if (targetNode != null && targetPoint != null)
                table.Rows.Add("InsertAsSubNode: " + InsertAsSubNode(targetNode, targetPoint).ToString());
            if (targetNode != null && draggedNode != null)
                table.Rows.Add("TargetNode is child: " + IsParent(draggedNode, targetNode).ToString());
            

            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            grid.Refresh();
        }

        private void tree_DragOver(object sender, DragEventArgs e)
        {
            DragInfo(e);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            draggedNode.Remove();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            tree.SelectedNode.Remove();
        }
    }
}
