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

﻿namespace algo_data_structures
{

    class generalSizes
    {
        public const float zeroFloatSize = 0;
        public const int zeroSize = 0;
        public const int MATRIX_STD_LENGTH = 100;
        public const int STD_LENGTH = 10000;
    }

    class oneDimensionalArrayType <Type>
    {

        public int Length = generalSizes.zeroSize;
        public int StartPoint = generalSizes.zeroSize;
        public int EndPoint = generalSizes.zeroSize;

        public Type[] oneDimensionalArray = new Type [generalSizes.STD_LENGTH];
    }

    class matrixType <Type>
    {
        public int Line = generalSizes.zeroSize;
        public int Column = generalSizes.zeroSize;

        public int StartLinePoint = generalSizes.zeroSize;
        public int EndLinePoint = generalSizes.zeroSize;
        public int StartColumnPoint = generalSizes.zeroSize;
        public int EndColumnPoint = generalSizes.zeroSize;

        public oneDimensionalArrayType <Type> mainDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> aboveMainDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> underMainDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> secondaryDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> aboveSecondaryDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> underSecondaryDiagonal = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> northElements = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> southElements = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> eastElements = new oneDimensionalArrayType<Type>();
        public oneDimensionalArrayType <Type> westElements = new oneDimensionalArrayType<Type>();

        public Type[,] matrix = new Type [generalSizes.MATRIX_STD_LENGTH, generalSizes.MATRIX_STD_LENGTH];
    }

    class binaryTreeType <Type>
    {
        public Type value;
        public  binaryTreeType <Type> leftLeaf = new binaryTreeType<Type>();
        public binaryTreeType <Type> rightLeaf = new binaryTreeType<Type>();
    }

    class graphType <Type>
    {
        public graphType ()
        {
            adjacencyMatrix.Line = vertices;
            adjacencyMatrix.Column = adjacencyMatrix.Line;
            adjacencyMatrix.StartLinePoint = adjacencyMatrix.StartColumnPoint;
            adjacencyMatrix.EndLinePoint = adjacencyMatrix.EndColumnPoint;
        }

        public int vertices = generalSizes.zeroSize;
        public int edges = generalSizes.zeroSize;

        public matrixType <Type> adjacencyMatrix = new matrixType<Type>();
        public oneDimensionalArrayType <Type> verticesValency = new oneDimensionalArrayType<Type>();
    }

    class linkedCentrum <Type>
    {

        public Type data;
        public linkedCentrum<Type> nextLinkedValue = new linkedCentrum<Type>();
    }

    class doubleLinkedCentrum <Type>
    {
        public Type data;
        public doubleLinkedCentrum<Type> nextDoubleLinkedValue = new doubleLinkedCentrum<Type>();
        public doubleLinkedCentrum<Type> previousDoubleLinkedValue = new doubleLinkedCentrum<Type>();
    } 
}
