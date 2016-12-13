using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace ActivityHelper
{
    internal static class SortedListExtensions
    {
        /// <summary>
        /// If Key exists, it replaces it with parameter + original
        /// </summary>
        /// <param name="sortedList"></param>
        /// <param name="keyToFind"></param>
        /// <param name="value"></param>
        public static void AddForExisting (this SortedList<OnlyDate, Time> sortedList, OnlyDate keyToFind, Time value)
        {
            Time existing = new Time (0);
            if (sortedList.TryGetValue (keyToFind, out existing))
            {
                sortedList.Remove (keyToFind);
                sortedList.Add (keyToFind, new Time (value.Seconds + existing.Seconds));
            }
            else
            {
                sortedList.Add (keyToFind, new Time (value.Seconds) );
            }
            
        }
        public static int BinarySearch<TKey, TValue>(this SortedList<TKey, TValue> sortedList, TKey keyToFind, IComparer<TKey> comparer = null)
        {
            // need to create an array because SortedList.keys is a private array
            var keys = sortedList.Keys;
            TKey[] keyArray = new TKey[keys.Count];
            for (int i = 0; i < keyArray.Length; i++)
                keyArray[i] = keys[i];

            if(comparer == null) comparer = Comparer<TKey>.Default;
            int index = Array.BinarySearch<TKey>(keyArray, keyToFind, comparer);
            return index;
        }

        public static IEnumerable<TKey> GetKeyRangeBetween<TKey, TValue>(this SortedList<TKey, TValue> sortedList, TKey low, TKey high, IComparer<TKey> comparer = null)
        {
            int lowIndex = sortedList.BinarySearch(low, comparer);
            if (lowIndex < 0)
            {
                // list doesn't contain the key, find nearest behind
                // If not found, BinarySearch returns the complement of the index
                lowIndex = ~lowIndex;
            }

            int highIndex = sortedList.BinarySearch(high, comparer);
            if (highIndex < 0)
            {
                // list doesn't contain the key, find nearest before
                // If not found, BinarySearch returns the complement of the index
                highIndex = ~highIndex - 1;
            }

            var keys = sortedList.Keys;
            for (int i = lowIndex; i <= highIndex; i++)
            {
                yield return keys[i];
            }
        }
    }
    internal static class DayChooserHelper
    {
        private static bool _isDateSettingOn = false;
        static public bool IsDateSettingOn {
                                                get { return _isDateSettingOn; }
                                                set
                                                {
                                                     if (value == false)
                                                    {
                                                        _isIntervalSearchOn  = false;
                                                        _savedDateTo         = null;
                                                        _savedDateFrom       = null;
                                                    }
                                                    _isDateSettingOn = value;
                                                }
                                            }
        private static bool _isIntervalSearchOn = false;
        static public bool IsIntervalSearchOn {
                                                get { return _isIntervalSearchOn; }
                                                set
                                                {
                                                     if (value == false)
                                                        _savedDateTo = null;
                                                    _isIntervalSearchOn = value;
                                                }
                                            }
        private static OnlyDate _savedDateFrom = null;
        static public OnlyDate DateFrom {
                                                    get { return _savedDateFrom; }
                                                    set {
                                                            if ( value == null ) {
                                                                _isDateSettingOn     = false;
                                                                _isIntervalSearchOn  = false;
                                                                _savedDateTo         = null;
                                                            }
                                                            else
                                                            {
                                                                _isDateSettingOn     = true;
                                                            }
                                                            _savedDateFrom = value;
                                                        }
                                                }
        private static OnlyDate _savedDateTo;
        static public OnlyDate DateTo {
                                             get {  return _savedDateTo; }
                                             set {  if ( value == null )
                                                        _isIntervalSearchOn  = false;
                                                    else if (_isDateSettingOn)
                                                        _isIntervalSearchOn = true;
                                                    _savedDateTo = value;
                                                 }
                                           }
    }
}
