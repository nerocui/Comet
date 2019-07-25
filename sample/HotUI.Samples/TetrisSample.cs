using System;
using System.Diagnostics;
using HotUI.Graphics;
using HotUI.Skia;

namespace HotUI.Samples
{
    public class TetrisSample : View
    {
        public TetrisSample()
        {
        }

        // define state
        // have timer start on button click new Timer use 
        // make it move the row/column

        // direction button to change the things 
        public void StarGame()
        {

        }


        [Body]
        View body() => new Grid(
            rows: new object[] { "*", "*", "*", "*", "*", "*", "*", "*", "*", "*" },
            columns: new object[] { "*", "*" , "*", "*", "*", "*", "*", "*", "*", "*" })
        {
            new DrawableControl(
                new SkiaShapeView(
                    new Rectangle().Fill(Color.Red)
                        .Style(DrawingStyle.Fill))).Cell(6,2)
        }.Frame(width:300, height:300, alignment: Alignment.Top);
    }
}
