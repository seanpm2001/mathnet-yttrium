#region Math.NET Neodym (LGPL) by Christoph Ruegg
// Math.NET Neodym, part of the Math.NET Project
// http://mathnet.opensourcedotnet.info
//
// Copyright (c) 2001-2008, Christoph R�egg,  http://christoph.ruegg.name
//						
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public 
// License along with this program; if not, write to the Free Software
// Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
#endregion

using System;
using MathNet.Numerics;

namespace MathNet.SignalProcessing.Windowing
{
    /// <summary>
    /// Hann window.
    /// </summary>
    /// <remarks>
    /// Named after Julius von Hann.
    /// </remarks>
    public class HannWindow :
        Window
    {
        /// <summary>
        /// Windowing function generator implementation.
        /// </summary>
        protected override
        double[]
        ComputeWindowCore(
            int width
            )
        {
            double phaseStep = (2.0 * Math.PI) / (width - 1.0);
            double[] w = new double[width];

            for (int i = 0; i < w.Length; i++)
            {
                w[i] = 0.5 - 0.5 * Math.Cos(i * phaseStep);
            }

            return w;
        }
    }
}
