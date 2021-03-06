﻿
using System;
using System.Windows.Controls;
using NControl.Abstractions;
using NControl.Win;
using NControl.WP81;
using NGraphics;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(NControlView), typeof(NControlViewRenderer))]
namespace NControl.WP81
{
    /// <summary>
    /// NControlView renderer.
    /// </summary>
    public class NControlViewRenderer: NControlViewRendererBase
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
            Initialize();
        }

        /// <summary>
        /// Overridden platform specific create canvas method
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        protected override ICanvas CreateCanvas(Canvas canvas)
        {
            return new CanvasCanvas(canvas);
        }
    }
}
