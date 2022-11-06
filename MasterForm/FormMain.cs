using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;


namespace MasterForm
{
    public partial class FormMain : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public FormMain()
        {
           
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 57);
            panelButton.Controls.Add(leftBorderBtn);

        }

        //Màu cho button
        private struct RGBColors
        {
            public static Color color = Color.FromArgb(24, 161, 251);
        }

        //Khi chọn Button sẽ hiện
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(249,240,241);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        // Trả về button khi không chọn
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.DodgerBlue;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            // add các controll vào panelShow
            
        }


        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_TrangChu());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_DonHang());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_SanPham());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_KhachHang());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_NhapHang());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_QuanLyNhanVien());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_CaiDat());
            ActivateButton(sender, RGBColors.color);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }
    }
}
