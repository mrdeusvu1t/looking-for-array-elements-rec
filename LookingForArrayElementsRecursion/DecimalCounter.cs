using System;

namespace LookingForArrayElementsRecursion
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            // TODO #5. Implement the method using recursion.
            if (ranges is null)
            {
                throw new ArgumentNullException("error");
            }

            if (arrayToSearch is null)
            {
                throw new ArgumentNullException("error");
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException("error");
                }
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length == 0)
                {
                    return 2;
                }
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length < 2 || ranges[i].Length > 2)
                {
                    throw new ArgumentException("error");
                }
            }

            if (ranges.Length == 0)
            {
                return 0;
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            return DecimalsCount(arrayToSearch, ranges);
        }

        public static int DecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int i = 0, int j = 0)
        {
            if (arrayToSearch[i] >= ranges[j][0] && arrayToSearch[i] <= ranges[j][1])
            {
                if (i + 1 >= arrayToSearch.Length)
                {
                    return 1;
                }

                return 1 + DecimalsCount(arrayToSearch, ranges, i + 1, 0);
            }

            if (j + 1 < ranges.Length)
            {
                return 0 + DecimalsCount(arrayToSearch, ranges, i, j + 1);
            }

            if (i + 1 < arrayToSearch.Length)
            {
                return 0 + DecimalsCount(arrayToSearch, ranges, i + 1, 0);
            }

            return 0;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count)
        {
            // TODO #6. Implement the method using recursion.
            if (ranges is null)
            {
                throw new ArgumentNullException("error");
            }

            if (arrayToSearch is null)
            {
                throw new ArgumentNullException("error");
            }

            if (ranges.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException("error");
                }
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length == 0)
                {
                    return 1;
                }
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length > 2 || ranges[i].Length < 2)
                {
                    throw new ArgumentException("error");
                }
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (count == 0)
            {
                return 0;
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            var endIndex = startIndex + count;
            return DecimalsCount2(arrayToSearch, ranges, startIndex, endIndex);
        }

        public static int DecimalsCount2(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int endIndex, int i = 0)
        {
            if (arrayToSearch[startIndex] >= ranges[i][0] && arrayToSearch[startIndex] <= ranges[i][1])
            {
                if (startIndex + 1 >= endIndex)
                {
                    return 1;
                }

                return 1 + DecimalsCount2(arrayToSearch, ranges, startIndex + 1, endIndex, 0);
            }

            if (i + 1 < ranges.Length)
            {
                return 0 + DecimalsCount2(arrayToSearch, ranges, startIndex, endIndex, i + 1);
            }

            if (startIndex + 1 < endIndex)
            {
                return 0 + DecimalsCount2(arrayToSearch, ranges, startIndex + 1, endIndex, 0);
            }

            return 0;
        }
    }
}
