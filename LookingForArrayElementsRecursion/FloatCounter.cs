using System;

namespace LookingForArrayElementsRecursion
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            // TODO #3. Implement the method using recursion.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException("error");
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException("error");
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException("error");
            }

            if (rangeStart.Length == 0)
            {
                return 0;
            }

            if (rangeEnd.Length == 0)
            {
                return 0;
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("error");
            }

            for (int i = 0; i < rangeStart.Length; i++)
            {
                if (rangeStart[i] > rangeEnd[i])
                {
                    throw new ArgumentException("error");
                }
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            return FloatsCount(arrayToSearch, rangeStart, rangeEnd);
        }

        public static int FloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int i = 0, int j = 0)
        {
            if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
            {
                if (i + 1 > arrayToSearch.Length - 1)
                {
                    return 1;
                }

                return 1 + FloatsCount(arrayToSearch, rangeStart, rangeEnd, i + 1, 0);
            }

            if (j + 1 < rangeStart.Length)
            {
                return 0 + FloatsCount(arrayToSearch, rangeStart, rangeEnd, i, j + 1);
            }

            if (i + 1 < arrayToSearch.Length)
            {
                return 0 + FloatsCount(arrayToSearch, rangeStart, rangeEnd, i + 1, 0);
            }

            return 0;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            // TODO #4. Implement the method using recursion.
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (arrayToSearch is null)
            {
                throw new ArgumentNullException("error");
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException("error");
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException("error");
            }

            if (rangeStart.Length == 0)
            {
                return 0;
            }

            if (rangeEnd.Length == 0)
            {
                return 0;
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("error");
            }

            for (int i = 0; i < rangeStart.Length; i++)
            {
                if (rangeStart[i] > rangeEnd[i])
                {
                    throw new ArgumentException("error");
                }
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            var endIndex = startIndex + count;

            return FloatsCount2(arrayToSearch, rangeStart, rangeEnd, startIndex, endIndex);
        }

        public static int FloatsCount2(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int endIndex, int i = 0)
        {
            if (arrayToSearch[startIndex] >= rangeStart[i] && arrayToSearch[startIndex] <= rangeEnd[i])
            {
                if (startIndex + 1 >= endIndex)
                {
                    return 1;
                }

                return 1 + FloatsCount2(arrayToSearch, rangeStart, rangeEnd, startIndex + 1, endIndex, 0);
            }

            if (i + 1 < rangeStart.Length)
            {
                return 0 + FloatsCount2(arrayToSearch, rangeStart, rangeEnd, startIndex, endIndex, i + 1);
            }

            if (startIndex + 1 < endIndex)
            {
                return 0 + FloatsCount2(arrayToSearch, rangeStart, rangeEnd, startIndex + 1, endIndex, 0);
            }

            return 0;
        }
    }
}
