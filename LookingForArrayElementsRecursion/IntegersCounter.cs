using System;

namespace LookingForArrayElementsRecursion
{
    public static class IntegersCounter
    {
        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor)
        {
            // TODO #1. Implement the method using recursion.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException("error");
            }

            if (elementsToSearchFor is null)
            {
                throw new ArgumentNullException("error");
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            if (elementsToSearchFor.Length == 0)
            {
                return 0;
            }

            return IntegersCount(arrayToSearch, elementsToSearchFor);
        }

        public static int IntegersCount(int[] arrayToSearch, int[] elementsToSearchFor, int i = 0, int j = 0)
        {
            if (arrayToSearch[i] == elementsToSearchFor[j])
            {
                return 1 + IntegersCount(arrayToSearch, elementsToSearchFor, i + 1, 0);
            }

            if (j + 1 < elementsToSearchFor.Length)
            {
                return 0 + IntegersCount(arrayToSearch, elementsToSearchFor, i, j + 1);
            }

            if (i + 1 < arrayToSearch.Length)
            {
                return 0 + IntegersCount(arrayToSearch, elementsToSearchFor, i + 1, 0);
            }

            return 0;
        }

        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements withing the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int count)
        {
            // TODO #2. Implement the method using recursion.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException("error");
            }

            if (elementsToSearchFor is null)
            {
                throw new ArgumentNullException("error");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            if (elementsToSearchFor.Length == 0)
            {
                return 0;
            }

            int endIndex = startIndex + count;

            return IntegersCount2(arrayToSearch, elementsToSearchFor, startIndex, endIndex );
        }

        public static int IntegersCount2(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int endIndex, int i = 0)
        {
            if (arrayToSearch[startIndex] == elementsToSearchFor[i])
            {
                return 1 + IntegersCount2(arrayToSearch, elementsToSearchFor, startIndex + 1, endIndex, 0);
            }

            if (i + 1 < elementsToSearchFor.Length)
            {
                return 0 + IntegersCount2(arrayToSearch, elementsToSearchFor, startIndex, endIndex, i + 1);
            }

            if (startIndex + 1 < endIndex)
            {
                return 0 + IntegersCount2(arrayToSearch, elementsToSearchFor, startIndex + 1, endIndex, 0);
            }

            return 0;
        }

    }
}
