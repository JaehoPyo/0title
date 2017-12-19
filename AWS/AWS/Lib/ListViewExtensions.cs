using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AWS.Lib
{
    public static class ListViewExtensions
    {
        public static void PrintData(this ListView listView, Point location, Graphics graphics, Brush headerBrush, Brush dataBrush, Pen gridPen)
        {
            const int x_margin = 3;
            const int y_margin = 3;
            float x = location.X;
            float y = location.Y;

            //See How tall rows should be.
            SizeF row_size = graphics.MeasureString(listView.Columns[0].Text, listView.Font);
            int row_height = (int)row_size.Height + 2 * y_margin;

            // Get the screen's horizontal resolution.
            float screen_res_x;
            using (Graphics screen_gr = listView.CreateGraphics())
            {
                screen_res_x = screen_gr.DpiX;
            }

            // Scale factor to convert from screen pixels
            // to printer units (100ths of inches).
            float screen_to_printer = 100 / screen_res_x;

            // Get the column widths in printer dots.
            float[] col_wids = new float[listView.Columns.Count];
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                col_wids[i] = (listView.Columns[i].Width + 4 * x_margin) * screen_to_printer;
            }

            int num_columns = listView.Columns.Count;
            using (StringFormat string_format = new StringFormat())
            {
                // Draw the column headers.
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;
                for (int i = 0; i < num_columns; i++)
                {
                    RectangleF rect = new RectangleF(x, y, col_wids[i], row_height);
                    graphics.DrawString(listView.Columns[i].Text, listView.Font, headerBrush, rect, string_format);
                    graphics.DrawRectangle(gridPen, rect);
                    x += col_wids[i];
                }
                y += row_height;

                // Draw the data
                foreach (ListViewItem item in listView.Items)
                {
                    x = location.X;
                    for (int i = 0; i < num_columns; i++)
                    {
                        RectangleF rect = new RectangleF( x + x_margin, y, col_wids[i] - x_margin, row_height);
                        switch (listView.Columns[i].TextAlign)
                        {
                            case HorizontalAlignment.Left:
                                string_format.Alignment = StringAlignment.Near;
                                break;
                            case HorizontalAlignment.Center:
                                string_format.Alignment = StringAlignment.Center;
                                break;
                            case HorizontalAlignment.Right:
                                string_format.Alignment = StringAlignment.Far;
                                break;
                        }
                        graphics.DrawString(item.SubItems[i].Text, listView.Font, dataBrush, rect, string_format);
                        rect = new RectangleF(x, y, col_wids[i], row_height);
                        graphics.DrawRectangle(gridPen, rect);
                        x += col_wids[i];
                    }
                    y += row_height;
                }
            }

        }

        // Draw a RectangleF.
        public static void DrawRectangle(this Graphics gr, Pen pen, RectangleF rectf)
        {
            gr.DrawRectangle(pen, rectf.Left, rectf.Top, rectf.Width, rectf.Height);
        }
    }
}
