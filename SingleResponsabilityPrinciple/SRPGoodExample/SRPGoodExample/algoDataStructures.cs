namespace algo_data_structures
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

    class limits <Type>
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
