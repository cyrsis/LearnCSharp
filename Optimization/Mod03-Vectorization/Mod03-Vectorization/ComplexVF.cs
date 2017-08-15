using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Vectorization
{
    struct ComplexVF
    {
        private Vector<float> _real;
        private Vector<float> _imaginary;

        public ComplexVF(Vector<float> real, Vector<float> imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public Vector<float> MagnitudeSquared
        {
            get { return _real * _real + _imaginary * _imaginary; }
        }

        public static ComplexVF operator +(ComplexVF a, ComplexVF b)
        {
            return new ComplexVF(a._real + b._real, a._imaginary + b._imaginary);
        }

        public static ComplexVF operator *(ComplexVF a, ComplexVF b)
        {
            return new ComplexVF(
                a._real * b._real - a._imaginary * b._imaginary,
                a._real * b._imaginary + a._imaginary * b._real
                );
        }
    }
}
