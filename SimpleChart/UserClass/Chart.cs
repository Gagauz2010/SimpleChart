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

        private float step, stepPart;
        private float OXbegin, OYbegin;
        private float shiftSpeed = 5;
        private Panel panel;
        private LinkedList<PointF> points;
        private Func<float, float> myFunc;
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
        public Chart(Panel panel, Func<float, float> myFunc, float step = 10, float OXbegin = 0, float OYbegin = 0)
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
            points = new LinkedList<PointF>();
            createPoints();

            e.Graphics.Clear(panel.BackColor);
            
            flipYAxis(sender, e);
            drawAxis(sender, e);
            drawGraph(sender, e);
        }

        private void flipYAxis (object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            e.Graphics.ScaleTransform(1.0F, -1.0F);
            e.Graphics.TranslateTransform(0.0F, -p.Height);
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
            g.DrawLine(axisPen, OXbegin, 0, OXbegin, panel.Height);
        }

        private void drawAxisY (object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLine(axisPen, 0, OYbegin, panel.Width, OYbegin);
        }

        private void drawGrid(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            //сетка X
            for (int i = (int)(-OXbegin / step); i <= (int)((panel.Width - OXbegin) / step); i++)
                g.DrawLine(gridPen, i * step + OXbegin, 0, i * step + OXbegin, panel.Height);

            //сетка Y
            for (int i = (int)(-OYbegin / step); i <= (int)((panel.Height - OYbegin) / step); i++)
                g.DrawLine(gridPen, 0, i * step + OYbegin, panel.Width, i * step + OYbegin);
        }

        private void drawGraph (object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            PointF[] line = new PointF[points.Count];
            points.CopyTo(line, 0);
            g.DrawCurve(graphPen, line);
        }

        #endregion

        #region Calculations
        
        private void createPoints(float xShift = 0, float yShift = 0)
        {
            for (int i = (int)(-OXbegin / step); i <= (panel.Width-OXbegin) / step; i++) 
                points.AddLast(new PointF(i * step + OXbegin, myFunc(i) * step + OYbegin));
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
            OXbegin += shiftSpeed;
            panel.Refresh();
        }

        public void rightShift()
        {
            OXbegin -= shiftSpeed;
            panel.Refresh();
        }

        public void upShift()
        {
            OYbegin += shiftSpeed;
            panel.Refresh();
        }

        public void downShift()
        {
            OYbegin -= shiftSpeed;
            panel.Refresh();
        }

        #endregion
    }
}