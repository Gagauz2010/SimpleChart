using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleChart
{
    /// <summary>
    /// Класс отрисовки простого графика на элементе System.Windows.Forms.Panel
    /// </summary>
    class Chart
    {
        #region Parameter

        private double step, stepPart;
        private double OXbegin, OYbegin;
        private Panel panel;
        private List<Point> points;
        private Func<Double, Double> myFunc;
        private Pen gridPen = new Pen(Color.LightGray, 1f);
        private Pen axisPen = new Pen(ColorTranslator.FromHtml("#363636"), 2);
        private Pen graphPen = new Pen(Color.BlueViolet, 2);

        #endregion

        /// <summary>
        /// Конструктор класса Chart
        /// </summary>
        /// <param name="panel">Коспонент Panel на котором будет отрисовываться график функции myFunc</param>
        /// <param name="myFunc">Функция <in Double, out Double> для построения графика</param>
        /// <param name="step">Шаг для единичного отрезка в системе координат Panel. По умолчанию 10</param>
        /// <param name="OXbegin">Отступ для начала оси OX в системе координат Panel. По умолчанию 0</param>
        /// <param name="OYbegin">Отступ для начала оси OY в системе координат Panel. По умолчанию 0</param>
        public Chart(Panel panel, Func<Double, Double> myFunc, double step = 10, double OXbegin = 0, double OYbegin = 0)
        {
            this.panel = panel;
            this.step = step;
            this.OXbegin = OXbegin;
            this.OYbegin = OYbegin;
            this.myFunc = myFunc;

            stepPart = step / 4;

            panel.Paint += updateLayer;
        }

        #region Basic drawnings

        private void updateLayer (object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(panel.BackColor);
            flipYAxis(sender, e);
            drawAxis(sender, e);
            drawGraph(sender, e);
        }

        private void flipYAxis (object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            e.Graphics.ScaleTransform(1.0F, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -(float)p.Height);
        }
        

        private void drawAxis (object sender, PaintEventArgs e)
        {
            drawGrid(sender, e);
            drawAxisX(sender, e);
            drawAxisY(sender, e);
        }

        private void drawAxisX (object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLine(axisPen, (float)OXbegin, 0, (float)OXbegin, panel.Height);
        }

        private void drawAxisY (object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLine(axisPen, 0, (float)OYbegin, panel.Width, (float)OYbegin);
        }

        private void drawGrid(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            //сетка X
            for (int i = (int)(-OXbegin / step); i <= (int)((panel.Width - OXbegin) / step); i++)
                g.DrawLine(gridPen, (float)(i * step + OXbegin), 0, (float)(i * step + OXbegin), panel.Height);

            //сетка Y
            for (int i = (int)(-OYbegin / step); i <= (int)((panel.Height - OYbegin) / step); i++)
                g.DrawLine(gridPen, 0, (float)(i * step + OYbegin), panel.Width, (float)(i * step + OYbegin));
        }

        private void drawGraph (object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        #region Calculations
        
        private void createPoints()
        {
            for (int i = 0; i <= panel.Width; i++) 
                points.Add(coordinateConverter(new[] { i, myFunc(i)}));
        }

        private Point coordinateConverter (double[] originalPoint, bool toPanelCoord = false)
        {
            Point point;

            if (toPanelCoord)
                point = new Point( originalPoint[0] * step + OXbegin, originalPoint[1] * step + OYbegin );
            else
                point = new Point((originalPoint[0] - OXbegin) / step, (originalPoint[1] - OYbegin) / step );

            return point;
        }

        #endregion

        #region Public draw methods like zoom and shifting axis

        public void zoomInOut(int value)
        {
            step = stepPart * value;
            panel.Refresh();
        }

        public void leftShift()
        {
            OXbegin += 2;
            panel.Refresh();
        }

        public void rightShift()
        {
            OXbegin -= 2;
            panel.Refresh();
        }

        public void upShift()
        {
            OYbegin += 2;
            panel.Refresh();
        }

        public void downShift()
        {
            OYbegin -= 2;
            panel.Refresh();
        }

        #endregion
    }
}