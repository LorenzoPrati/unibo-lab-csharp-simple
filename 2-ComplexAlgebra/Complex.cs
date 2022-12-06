using System;
using System.Collections.Generic;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public double Modulus => Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
        public double Phase => Math.Atan(Imaginary / Real);
        
        public Complex(double re, double im)
        {
            Real = re;
            Imaginary = im;
        }

        public Complex Complement() => new Complex(Real, -Imaginary);

        public Complex Plus(Complex c) => new Complex(Real + c.Real, Imaginary + c.Imaginary);

        public Complex Minus(Complex c) => new Complex(Real - c.Real, Imaginary - c.Imaginary);

        public bool Equals(Complex c) => Real == c.Real && Imaginary == c.Imaginary;

        public override string ToString() => Imaginary == 0
            ? Real + ""
            : (Real == 0 ? "" : Real)
                + (Real != 0 && Imaginary > 0 ? "+" : "")
                + (Imaginary == 1 ? "" : (Imaginary == -1 ? "-" : Imaginary + "")) + "i";

        public override int GetHashCode() => HashCode.Combine(Real, Imaginary, Modulus, Phase);

    }
}