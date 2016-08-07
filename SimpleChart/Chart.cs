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
        private double step;
        private double OXbegin, OYbegin;
        private Panel panel;
        private List<double[,]> points;
        private Func<Double, Double> myFunc;

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
            drawAxisX(sender, e);
            drawAxisY(sender, e);
        }

        private void drawAxisX (object sender, PaintEventArgs e)
        {

        }

        private void drawAxisY (object sender, PaintEventArgs e)
        {

        }

        private void drawGraph (object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region Calculations

        private void createPoints()
        {
            
        }

        private double[] coordinateConverter (double[] original, bool toPanelCoord = false)
        {
            double[] point;

            if (toPanelCoord)
                point = new[] { original[0] * step + OXbegin, original[1] * step + OYbegin };
            else
                point = new[] { (original[0] - OXbegin) / step, (original[1] - OYbegin) / step };

            return point;
        }

        #endregion

        #region Public draw methods like zoom and shifting axis

        public void zoomIn()
        {
            step -= 2;
            panel.Refresh();
        }

        public void zoomOut()
        {
            step += 2;
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