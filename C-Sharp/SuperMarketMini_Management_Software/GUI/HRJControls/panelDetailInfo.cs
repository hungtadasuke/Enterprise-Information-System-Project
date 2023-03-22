using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class panelDetailInfo : Panel
    {
        //fields
        private Label lblOrdinalNumber;
        private Label lblDetailProductId;
        private Label lblDetailProductName;
        private TextBox txtDetailQuantity;
        private Button btnDetailQuantityAdd;
        private Button btnDetailQuantitySub;
        private Label lblDetailProductPrice;
        private Label lblDetailUnitPrice;
        private PictureBox picTrash;
        private int _qtyWarehouse;
        private double undoDetailUnitPrice;

        //properties
        public Label LblOrdinalNumber { get => lblOrdinalNumber; set => lblOrdinalNumber = value; }
        public Label LblDetailProductId { get => lblDetailProductId; set => lblDetailProductId = value; }
        public Label LblDetailProductName { get => lblDetailProductName; set => lblDetailProductName = value; }
        public TextBox TxtDetailQuantity { get => txtDetailQuantity; set => txtDetailQuantity = value; }
        public Button BtnDetailQuantityAdd { get => btnDetailQuantityAdd; set => btnDetailQuantityAdd = value; }
        public Button BtnDetailQuantitySub { get => btnDetailQuantitySub; set => btnDetailQuantitySub = value; }
        public Label LblDetailProductPrice { get => lblDetailProductPrice; set => lblDetailProductPrice = value; }
        public Label LblDetailUnitPrice { get => lblDetailUnitPrice; set => lblDetailUnitPrice = value; }
        public PictureBox PicTrash { get => picTrash; set => picTrash = value; }
        public int QtyWarehouse { get => _qtyWarehouse; set => _qtyWarehouse = value; }
        public double UndoDetailUnitPrice { get => undoDetailUnitPrice; set => undoDetailUnitPrice = value; }

        //constructor
        public panelDetailInfo(int ordinalNumber, string productId, string productName, int quantity, double productPrice, int qtyWarehouse, Form parentForm)
        {
            //Khởi tạo biến thành viên
            this.LblOrdinalNumber = new Label();
            this.LblDetailProductId = new Label();
            this.LblDetailProductName = new Label();
            this.TxtDetailQuantity = new TextBox();
            this.BtnDetailQuantityAdd = new Button();
            this.BtnDetailQuantitySub = new Button();
            this.LblDetailProductPrice = new Label();
            this.LblDetailUnitPrice = new Label();
            this.PicTrash = new PictureBox();
            this.QtyWarehouse = qtyWarehouse;

            // 
            // this
            // 
            this.BackColor = Color.White;
            this.Controls.Add(this.BtnDetailQuantitySub);
            this.Controls.Add(this.BtnDetailQuantityAdd);
            this.Controls.Add(this.LblDetailUnitPrice);
            this.Controls.Add(this.LblDetailProductPrice);
            this.Controls.Add(this.PicTrash);
            this.Controls.Add(this.LblDetailProductId);
            this.Controls.Add(this.TxtDetailQuantity);
            this.Controls.Add(this.LblDetailProductName);
            this.Controls.Add(this.LblOrdinalNumber);
            this.Location = new Point(3, 3);
            this.Margin = new Padding(3, 3, 3, 0);
            this.Size = new Size(643, 100);
            //Hover
            this.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.MouseLeave += new EventHandler(this.OnMouseLeave);

            // 
            // lblOrdinalNumber
            // 
            this.LblOrdinalNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdinalNumber.Location = new Point(9, 15);
            this.LblOrdinalNumber.Size = new Size(31, 23);
            this.LblOrdinalNumber.Text = ordinalNumber.ToString();
            this.LblOrdinalNumber.TextAlign = ContentAlignment.MiddleLeft;
            this.LblOrdinalNumber.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.LblOrdinalNumber.MouseLeave += new EventHandler(this.OnMouseLeave);

            // 
            // lblDetailProductId
            // 
            this.LblDetailProductId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.LblDetailProductId.Location = new Point(65, 15);
            this.LblDetailProductId.Size = new Size(51, 23);
            this.LblDetailProductId.Text = productId;
            this.LblDetailProductId.TextAlign = ContentAlignment.MiddleLeft;
            this.LblDetailProductId.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.LblDetailProductId.MouseLeave += new EventHandler(this.OnMouseLeave);

            // 
            // lblDetailProductName
            // 
            this.LblDetailProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.LblDetailProductName.Location = new Point(144, 15);
            this.LblDetailProductName.Size = new Size(434, 23);
            this.LblDetailProductName.Text = productName;
            this.LblDetailProductName.TextAlign = ContentAlignment.MiddleLeft;
            this.LblDetailProductName.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.LblDetailProductName.MouseLeave += new EventHandler(this.OnMouseLeave);

            // 
            // txtDetailQuantity
            // 
            this.TxtDetailQuantity.BackColor = Color.WhiteSmoke;
            this.TxtDetailQuantity.BorderStyle = BorderStyle.None;
            this.TxtDetailQuantity.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetailQuantity.Location = new Point(68, 62);
            this.TxtDetailQuantity.Size = new Size(44, 18);
            this.TxtDetailQuantity.Text = quantity.ToString();
            this.TxtDetailQuantity.TextAlign = HorizontalAlignment.Center;
            this.TxtDetailQuantity.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.TxtDetailQuantity.MouseLeave += new EventHandler(this.OnMouseLeave);
            this.TxtDetailQuantity.Select(0, 0);
            this.TxtDetailQuantity.TextChanged += delegate
            {
                int currentQuantity = -1;
                bool castCurrentQuantity = int.TryParse(this.txtDetailQuantity.Text, out currentQuantity);
                if ((castCurrentQuantity == false || currentQuantity == 0) && this.TxtDetailQuantity.Text != "")
                {
                    this.txtDetailQuantity.Text = "1";
                }
                else if (castCurrentQuantity)
                {
                    if (currentQuantity == 1 && currentQuantity == QtyWarehouse)
                    {
                        this.btnDetailQuantityAdd.Enabled = false;
                        this.btnDetailQuantitySub.Enabled = false;
                        this.txtDetailQuantity.ForeColor = Color.Red;
                    }
                    else if (currentQuantity == 1)
                    {
                        this.btnDetailQuantitySub.Enabled = false;
                    }
                    else if (currentQuantity == QtyWarehouse || currentQuantity > QtyWarehouse)
                    {
                        this.txtDetailQuantity.Text = _qtyWarehouse.ToString();
                        this.btnDetailQuantityAdd.Enabled = false;
                        this.txtDetailQuantity.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.btnDetailQuantityAdd.Enabled = true;
                        this.btnDetailQuantitySub.Enabled = true;
                        this.txtDetailQuantity.ForeColor = Color.Black;
                    };
                    parentForm.ActiveControl = null;
                    this.lblDetailUnitPrice.Text = String.Format("{0:0,0}", double.Parse(this.lblDetailProductPrice.Text) * currentQuantity);
                }
                else
                {
                    this.btnDetailQuantityAdd.Enabled = true;
                    this.btnDetailQuantitySub.Enabled = true;
                    this.txtDetailQuantity.ForeColor = Color.Black;
                };
            };

            // 
            // btnDetailQuantitySub
            // 
            this.BtnDetailQuantitySub.Cursor = Cursors.Hand;
            this.BtnDetailQuantitySub.Image = global::GUI.Properties.Resources.minus1;
            this.BtnDetailQuantitySub.Location = new Point(35, 60);
            this.BtnDetailQuantitySub.Size = new Size(20, 20);
            this.BtnDetailQuantitySub.TabStop = false;
            this.BtnDetailQuantitySub.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.BtnDetailQuantitySub.MouseLeave += new EventHandler(this.OnMouseLeave);
            this.BtnDetailQuantitySub.Enabled = true;
            this.BtnDetailQuantitySub.MouseClick += delegate
            {
                if (this.txtDetailQuantity.Text.Equals(""))
                {
                    this.txtDetailQuantity.Text = "1";
                }
                else if (!this.txtDetailQuantity.Text.Equals("1"))
                {
                    int currentQuantity = int.Parse(this.txtDetailQuantity.Text) - 1;
                    this.txtDetailQuantity.Text = currentQuantity.ToString();
                } else { };
                parentForm.ActiveControl = null;
            };

            // 
            // btnDetailQuantityAdd
            // 
            this.BtnDetailQuantityAdd.Cursor = Cursors.Hand;
            this.BtnDetailQuantityAdd.Image = global::GUI.Properties.Resources.plus1;
            this.BtnDetailQuantityAdd.Location = new Point(128, 60);
            this.BtnDetailQuantityAdd.Size = new Size(20, 20);
            this.BtnDetailQuantityAdd.TabStop = false;
            this.BtnDetailQuantityAdd.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.BtnDetailQuantityAdd.MouseLeave += new EventHandler(this.OnMouseLeave);
            this.BtnDetailQuantityAdd.MouseClick += delegate
            {
                if (this.txtDetailQuantity.Text.Equals(""))
                {
                    this.txtDetailQuantity.Text = "1";
                } else
                {
                    int currentQuantity = int.Parse(this.txtDetailQuantity.Text) + 1;
                    this.txtDetailQuantity.Text = currentQuantity.ToString();
                }
                parentForm.ActiveControl = null;
            };

            //Khi khởi tạo một object panelDetailInfo
            //Nếu số lượng còn của sản phẩm là 1 thì ẩn hai button addQuantity và subQuantity
            if(quantity == 1 && quantity == QtyWarehouse)
            {
                this.btnDetailQuantityAdd.Enabled = false;
                this.btnDetailQuantitySub.Enabled = false;
                this.txtDetailQuantity.ForeColor = Color.Red;
                parentForm.ActiveControl = null;
            }


            // 
            // lblDetailProductPrice
            // 
            this.LblDetailProductPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.LblDetailProductPrice.Location = new Point(354, 62);
            this.LblDetailProductPrice.Size = new Size(92, 23);
            this.LblDetailProductPrice.Text = String.Format("{0:0,0}", productPrice);
            this.LblDetailProductPrice.TextAlign = ContentAlignment.MiddleLeft;
            this.LblDetailProductPrice.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.LblDetailProductPrice.MouseLeave += new EventHandler(this.OnMouseLeave);
            // 
            // lblDetailUnitPrice
            // 
            this.LblDetailUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.LblDetailUnitPrice.Location = new Point(479, 62);
            this.LblDetailUnitPrice.Size = new Size(99, 23);
            this.LblDetailUnitPrice.Text = String.Format("{0:0,0}", productPrice * quantity);
            this.LblDetailUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            this.LblDetailUnitPrice.MouseEnter += new EventHandler(this.OnMouseEnter);
            this.LblDetailUnitPrice.MouseLeave += new EventHandler(this.OnMouseLeave);
            
            //Thiết lập giá trị ban đầu cho undoDetailUnitPrice
            this.UndoDetailUnitPrice = double.Parse(this.lblDetailUnitPrice.Text);

            // 
            // picTrash
            // 
            this.PicTrash.Cursor = Cursors.Hand;
            this.PicTrash.Image = global::GUI.Properties.Resources.bin;
            this.PicTrash.Location = new Point(591, 45);
            this.PicTrash.Size = new Size(16, 17);
            this.PicTrash.SizeMode = PictureBoxSizeMode.Zoom;
            this.PicTrash.TabStop = false;
            this.PicTrash.MouseEnter += new EventHandler(this.picTrash_MouseEnter);
            this.PicTrash.MouseLeave += new EventHandler(this.picTrash_MouseLeave);
        }

        //Các sự kiện hover
        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.TxtDetailQuantity.BackColor = Color.White;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.TxtDetailQuantity.BackColor = Color.WhiteSmoke;
        }

        private void picTrash_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(sender, e);
            this.PicTrash.Image = global::GUI.Properties.Resources.bin__1_;
        }

        private void picTrash_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(sender, e);
            this.PicTrash.Image = global::GUI.Properties.Resources.bin;
        }
    }
}
