/*
MIT License

Copyright (c) 2020 Cigan Oliviu David

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace calculation_structures
{
    class generalSizes
    {
        public const float zeroFloatSize = 0;
        public const int zeroSize = 0;
        public const int MATRIX_STD_LENGTH = 100;
        public const int STD_LENGTH = 10000;
    }
    class limits<Type>
    {
        public Type minimLimit;
        public Type maximLimit;
    }

    class linearEquation
    {
        public float slope = generalSizes.zeroFloatSize;
        public float y_intercept = generalSizes.zeroFloatSize;
        public float root = generalSizes.zeroFloatSize;
    }

    class quadraticEquation
    {
        private float standardInitialiser = 0;

        public float coefficient_a = generalSizes.zeroFloatSize;
        public float coefficient_b = generalSizes.zeroFloatSize;
        public float coefficient_c = generalSizes.zeroFloatSize;

        limits<float> roots = new limits<float>();
    }

    class complexNumber
    {
        public float ComplexNumberLength = generalSizes.zeroFloatSize;
        public float RealPart = generalSizes.zeroFloatSize;
        public float ImaginaryPaty = generalSizes.zeroFloatSize;
    }
}