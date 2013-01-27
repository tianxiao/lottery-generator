using System.Collections.Generic;
using System.Drawing;
using Lottery;
using System.Diagnostics;


namespace TestDrawPrimitive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //int width = this.Width;
            //int height = this.Height;
            int width = 1000;
            int height = 800;
            translation.x = width / 2.0;
            translation.y = height / 2.0;
            rotation = txMatrix2.YImageOperation();

            rotation.Scale(scale);
            
            Graphics dc = e.Graphics;

            RenderCoordinateFrame(dc,rotation, translation);

            RenderDisk(world.DiskList,dc,rotation,translation);
            RenderRectangle(world.RectBoundary,dc,rotation,translation);


            base.OnPaint(e);
        }

        private void RenderCoordinateFrame(Graphics dc, txMatrix2 rotation, txVector2 translation)
        {
            Pen yellopen = new Pen(Color.Yellow, 1);
            txVector2 origin = txVector2.Zero();
            origin = translation + rotation * origin;
            int X = (int) origin.x;
            int Y = (int) origin.y;
            dc.DrawLine(yellopen,new Point(-10000, Y),new Point(10000, Y));
            dc.DrawLine(yellopen, new Point(X, 10000), new Point(X, -10000));
        }



        private void RenderDisk(List<txPhysicalShpere> disklist, Graphics dc, txMatrix2 rotation, txVector2 translation)
        {
            // Draw disklist
            Pen grayPen = new Pen(Color.Gray,2);
            foreach ( txPhysicalShpere disk in disklist)
            {
                txVector2 ob = translation + rotation * disk.Position;
                double xlb = ob.x-txPhysicalShpere.RADIUS;
                double ylb = ob.y-txPhysicalShpere.RADIUS;

                dc.DrawEllipse(grayPen,(int)xlb,(int)ylb,(int)txPhysicalShpere.DIAMETER,(int)txPhysicalShpere.DIAMETER);
            }
        }

        private void RenderRectangle(txRectangle rect, Graphics dc, txMatrix2 rotation, txVector2 translation)
        {
            // Draw Rectangle
            Pen redPen = new Pen(Color.Red,5);
            txVector2 lb = translation + rotation * rect.LeftBottomV;
            txVector2 rb = translation + rotation * rect.RightBottomV;
            txVector2 rt = translation + rotation * rect.RightTopV;
            txVector2 lt = translation + rotation * rect.LeftTopV;
            //int width = (int)(rect.RightTopV.x - rect.LeftBottomV.x);
            //int height = (int)(rect.RightTopV.y - rect.LeftBottomV.y);
            //Trace.Assert(width > 0);
            //Trace.Assert(height > 0);
            //double xlb = lb.x;
            //double ylb = lb.y;
            //dc.DrawRectangle(redPen,(int)xlb,(int)ylb,width,height);
            //dc.DrawRectangle(redPen, 100, 200, 800, 600);
            Point[] points = 
            {
                new Point((int)lb.x,(int)lb.y),
                new Point((int)rb.x,(int)rb.y),
                new Point((int)rt.x,(int)rt.y),
                new Point((int)lt.x,(int)lt.y),
                new Point((int)lb.x,(int)lb.y)
            };

            dc.DrawLines(redPen, points);
        }

        


        // 
        txWorld world;
        txMatrix2 rotation;
        txVector2 translation;
        double scale = 1.0;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 694);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            world = new txWorld();
            world.SetUpScene();

            const double step = 0.1;
            for (int i = 0; i < 20; i++)
            {
                world.Simulate(step);
                //OnPaint(CreateGraphics());
            }
        }

        #endregion
    }
}

