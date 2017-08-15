using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Vectorization
{
    struct ComplexF
    {
        private float _real;
        private float _imaginary;

        public ComplexF(float real, float imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public float MagnitudeSquared
        {
            get { return _real * _real + _imaginary * _imaginary; }
        }

        public static ComplexF operator +(ComplexF a, ComplexF b)
        {
            return new ComplexF(a._real + b._real, a._imaginary + b._imaginary);
        }

        public static ComplexF operator *(ComplexF a, ComplexF b)
        {
            return new ComplexF(
                a._real * b._real - a._imaginary * b._imaginary,
                a._real * b._imaginary + a._imaginary * b._real
                );
        }
    }
}
