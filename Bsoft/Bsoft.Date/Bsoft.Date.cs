using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Bsoft.Date
{
    public class BsoftDateConverter
    {
        public BsoftDateConverter()
        {
            //adddata();
        }
        static BsoftDateConverter()
        {
            adddata();
        }
        public const int Min_Nep_year = 1900;
        public const int Min_Nep_month = 1;
        public const int Min_Nep_day = 1;

        public const int Min_Eng_year = 1843;
        public const int Min_Eng_month = 4;
        public const int Min_Eng_day = 12;

        public const int Max_Nep_year = 2162;
        public const int Max_Nep_month = 12;
        public const int Max_Nep_day = 1;

        public const int Max_Eng_year = 2105;
        public const int Max_Eng_month = 04;
        public const int Max_Eng_day = 15;

        private static List<int> ints = new List<int>();
        private static void calCulateAdditions(DataTable dt)
        {
            ints.Add(0);
            int total = 0; int currentValue = 0;
            for (int r = 0; r < dt.Rows.Count; r++)
            {

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    currentValue = Convert.ToInt32(dt.Rows[r][c]);
                    total += currentValue;
                    ints.Add(total);
                    //  dt.Rows[r][c] = total;
                }
            }
        }



        private static void adddata()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            // 1975/01/01 BS is 1918/04/13 AD
            dt.Columns.Add("1"); dt.Columns.Add("2");
            dt.Columns.Add("3"); dt.Columns.Add("4");
            dt.Columns.Add("5"); dt.Columns.Add("6");
            dt.Columns.Add("7"); dt.Columns.Add("8");
            dt.Columns.Add("9"); dt.Columns.Add("10");
            dt.Columns.Add("11"); dt.Columns.Add("12");

            //baisakh 30 / 31
            //jesth 31 / 32
            //asar 31 / 32
            //31 / 32
            //31 / 32
            //30 / 31
            //29 / 30
            //29 / 30
            //29 / 30
            //29 / 30
            //29 / 30,
            //chait 30 / 31

            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1900
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1901
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1902
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1903
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1904
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1905
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1906
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1907
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1908
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1909
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1910
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1911
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1912
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1913
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//1914
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1915
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1916
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1917
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1918
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1919
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1920
            dt.Rows.Add(31, 31, 32, 31, 31, 30, 30, 29, 30, 29, 30, 30);//1921
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1922
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1923
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1924
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1925
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1926
            dt.Rows.Add(31, 31, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1927
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1928
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1929
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1930
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1931
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1932
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1933
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1934
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1935
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1936
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1937
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1938
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1939
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1940
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//1941
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1942
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1943
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1944
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1945
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1946
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1947
            dt.Rows.Add(31, 31, 32, 31, 31, 30, 30, 29, 30, 29, 30, 30);//1948
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1949
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1950
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1951
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1952
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1953
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1954
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1955
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1956
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1957
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1958
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1959
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1960
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1961
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1962
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1963
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1964
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1965
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1966
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1967
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//1968
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1969
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1970
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1971
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1972
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1973
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1974
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1975
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1976
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1977
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1978
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1979
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1980
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1981
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1982
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1983
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1984
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1985
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1986
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1987
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1988
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//1989
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1990
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//1991
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1992
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1993
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1994
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//1995
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//1996
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//1997
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//1998
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//1999
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2000
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2001
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2002
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2003
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2004
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2005
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2006
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2007
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31);//2008
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2009
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2010
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2011
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2012
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2013
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2014
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2015
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2016
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2017
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2018
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2019
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2020
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2021
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2022
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2023
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2024
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2025
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2026
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2027
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2028
            dt.Rows.Add(31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30);//2029
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2030
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2031
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2032
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2033
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2034
            dt.Rows.Add(30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31);//2035
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2036
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2037
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2038
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2039
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2040
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2041
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2042
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2043
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2044
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2045
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2046
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2047
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2048
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2049
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2050
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2051
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2052
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2053
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2054
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2055
            dt.Rows.Add(31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30);//2056
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2057
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2058
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2059
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2060
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2061
            dt.Rows.Add(30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31);//2062
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2063
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2064
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2065
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31);//2066
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2067
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2068
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2069
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2070
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2071
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2072
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2073
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2074
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2075
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2076
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2077
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2078
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2079
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2080
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2081
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2082
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2083
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2084
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2085
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2086
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2087
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2088
            dt.Rows.Add(30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31);//2089
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2090
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2091
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2092
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2093
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2094
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2095
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2096
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2097
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2098
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2099
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2100
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2101
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2102
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2103
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2104
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2105
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2106
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2107
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2108
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2109
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2110
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2111
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2112
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2113
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2114
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2115
            dt.Rows.Add(30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31);//2116
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2117
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2118
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2119
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2120
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2121
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2122
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2123
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2124
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2125
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2126
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2127
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2128
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2129
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2130
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2131
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2132
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2133
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2134
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2135
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2136
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2137
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2138
            dt.Rows.Add(30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2139
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2140
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2141
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2142
            dt.Rows.Add(30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31);//2143
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2144
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2145
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2146
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2147
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2148
            dt.Rows.Add(31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2149
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2150
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30);//2151
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2152
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30);//2153
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31);//2154
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2155
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2156
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2157
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31);//2158
            dt.Rows.Add(31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30);//2159
            dt.Rows.Add(31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30);//2160
            dt.Rows.Add(31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30);//2161


            calCulateAdditions(dt);
            dt = null;

        }

        /// <summary>
        /// for e to n
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns>Returns the days till given month 1st date eg 1975 ,1 returns 0 </returns>
        private static int DaysDifference(int year, int month, int day)
        {
            try
            {
                if (year < Min_Nep_year)
                {
                    throw new Exception("Invalid year ");
                }
                if (year == Min_Nep_year & month < Min_Nep_month)
                {
                    throw new Exception("Invalid month  ");
                }
                if (year == Min_Nep_year & month == Min_Nep_month & day < Min_Nep_day)
                {
                    throw new Exception("Invalid day  ");
                }
                if (month < 1)
                {
                    throw new Exception("Month should not be less than 1  ");
                }
                if (day < 1)
                {
                    throw new Exception("Day should not be less than 1 ");
                }
                int yearIndex = year - Min_Nep_year, monthIndex = month - 1;
                int Index = yearIndex * 12 + monthIndex;
                return ints[Index] + day - 1;
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime EnglishDate(NepaliDate dt)
        {
            int days = DaysDifference(dt.Year, dt.Month, dt.Day);
            DateTime ed = new DateTime(Min_Eng_year, Min_Eng_month, Min_Eng_day);
            return ed.AddDays(days);
        }
        public static NepaliDate NepaliDate(DateTime ed)
        {
            DateTime sed = new DateTime(Min_Eng_year, Min_Eng_month, Min_Eng_day);
            TimeSpan ts = new TimeSpan();
            ts = ed - sed;
            int[] ym;
            ym = AddDays(ts.Days);
            return new NepaliDate(ym[0], ym[1], ym[2]);

        }

        /// <summary>
        /// for n to e
        /// </summary>
        /// <param name="days"></param>
        /// <returns>Year containg days given</returns>
        private static int[] AddDays(int days)
        {
            int[] ym = new int[3];
            try
            {

                if (days < 0)
                {
                    throw new Exception("Days should not be less than 1  ");
                }
                if (days > ints[ints.Count - 1])
                {
                    throw new Exception("Days should not be more than  " + ints[ints.Count - 1].ToString());
                }

                int year = 0, month = 0;
                for (int i = 0; i < ints.Count - 1; i++)
                {
                    if (days >= ints[i] && days < ints[i + 1])
                    {
                        year = (i) / 12;
                        month = (i) % 12;
                        ym[0] = year + Min_Nep_year;
                        ym[1] = month + 1;
                        ym[2] = days - ints[i] + 1;
                        break;
                    }
                }
            }
            catch
            {
                ym[0] = 0;
                ym[1] = 0;
                ym[2] = 0;
            }
            return ym;
        }



        #region "validity check"
        public static bool isValidDay(int day)
        {
            if (day > 0 & day < 33)
                return true;
            else
                return false;
        }
        public static bool isValidMonth(int month)
        {
            if (month > 0 & month < 13)
                return true;
            else
                return false;
        }

        public static bool isValidYear(int year)
        {
            if (Min_Nep_year <= year & Max_Nep_year >= year)
                return true;
            else
                return false;
        }
        public static int daysInNepaliMonth(int year, int month)
        {
            if (isValidYear(year))
            {
                int yearIndex = year - Min_Nep_year, monthIndex = month - 1;
                int Index = yearIndex * 12 + monthIndex;

                return ints[Index + 1] - ints[Index];
            }
            return 0;
        }
        public static bool isValidDate(int year, int month, int day)
        {
            if (isValidYear(year))
            {
                if (isValidMonth(month))
                {
                    if (isValidDay(day))
                    {

                        if (daysInNepaliMonth(year, month) >= day)
                        {
                            return true;
                        }
                    }
                    else
                        return false;
                }
                else
                    return false;

            }
            else
                return false;

            return false;
        }
        /// <summary>
        /// format can be eg:
        /// 
        /// yyyy/mm/dd
        /// dd/mm/yyyy
        /// yyyymmdd
        /// 
        /// should have 4 , 2, 2 digits respectively.
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <ignoreDelimiter>To ignore delimiter set true</ignoreDelimiter>
        public static bool isValidDate(string date, string format, bool ignoreDelimiter)
        {
            date = Bsoft.Date.generalNepaliFunctions.getAsciiNepali(date);
            //if (date.Length != format.Length)
            //    return false;

            format = format.ToLower();

            if (format.IndexOf("yyyy") < 0)
            {
                throw new Exception("invalid format year");
            }
            if (format.IndexOf("mm") < 0 & format.IndexOf("month") < 0)
            {
                //if (format.IndexOf("mmStr") < 0)
                //{
                throw new Exception("invalid format month");
                //}
 
            }
            if (format.IndexOf("mm") >= 0 & format.IndexOf("month") >= 0)
            {
                //if (format.IndexOf("mmStr") < 0)
                //{
                throw new Exception("can have only one of format month and mm");
                //}
 
            }
            if (format.IndexOf("dd") < 0)
            {
                throw new Exception("invalid format day");
            }

            //if (!ignoreDelimiter)
            //{
            //    for (int i = 0; i < format.Length; i++)
            //    {
            //        if (!char.IsNumber(date[i]))
            //        {
            //            if (format[i] != date[i])
            //            {
            //                return false;
            //            }
            //        }
            //    }
            //}

            try
            {

                string months;
                int month;
                if (format.IndexOf("mm") < 0)
                {
                    //months = date.Substring(format.IndexOf("month"), 2);
                    month = generalNepaliFunctions.getMonthNo(date);
                }
                else
                {
                    months = date.Substring(format.IndexOf("mm"), 2);
                    month = Convert.ToInt16(months);
                }

                string tempdate = date;
                string tempformat = format.Replace("month", "mm");
                tempdate = tempdate.Replace(generalNepaliFunctions.getFullMonthName(month), "mm");
                string years = tempdate.Substring(tempformat.IndexOf("yyyy"), 4);
                int year = Convert.ToInt16(years);

                string days = tempdate.Substring(tempformat.IndexOf("dd"), 2);
                int day = Convert.ToInt16(days);

                return isValidDate(year, month, day);
            }
            catch
            {
                return false;
            }


        }
        #endregion


    }





    public class NepaliDate
    {
        public NepaliDate() { }
        int _year, _month, _day;


        public NepaliDate(int Year, int Month, int Day)
        {
            _year = Year; _month = Month; _day = Day;

        }
        public NepaliDate(NepaliDate nepalidate)
        {
            _year = nepalidate.Year; _month = nepalidate.Month; _day = nepalidate.Day;
        }
        public NepaliDate(DateTime EnglishDate_)
        {
            NepaliDate nepalidate = BsoftDateConverter.NepaliDate(EnglishDate_);
            _year = nepalidate.Year; _month = nepalidate.Month; _day = nepalidate.Day;
        }
        public static NepaliDate Today
        {
            get
            {
                return new NepaliDate(DateTime.Today.Date);
            }

        }
        /// <summary>
        /// format can be eg:
        /// 
        /// yyyy/mm/dd
        /// dd/mm/yyyy
        /// yyyymmdd
        /// 
        /// should have 4 , 2, 2 digits respectively.
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <ignoreDelimiter>To ignore delimiter set true</ignoreDelimiter>
        public NepaliDate(string date, string format, bool ignoreDelimiter)
        {
            date = Bsoft.Date.generalNepaliFunctions.getAsciiNepali(date);
            if (Bsoft.Date.BsoftDateConverter.isValidDate(date, format, ignoreDelimiter))
            {


                string months;
                if (format.IndexOf("mm") < 0)
                {
                    _month = generalNepaliFunctions.getMonthNo(date);
                }
                else
                {
                    months = date.Substring(format.IndexOf("mm"), 2);
                    _month = Convert.ToInt16(months);
                }

                //string years = date.Substring(format.IndexOf("yyyy"), 4);
                //_year = Convert.ToInt16(years);
                //string days = date.Substring(format.IndexOf("dd"), 2);
                //_day = Convert.ToInt16(days);

                string tempdate = date;
                string tempformat = format.Replace("month", "mm");
                tempdate = tempdate.Replace(generalNepaliFunctions.getFullMonthName(_month), "mm");
                string years = tempdate.Substring(tempformat.IndexOf("yyyy"), 4);
                _year = Convert.ToInt16(years);

                string days = tempdate.Substring(tempformat.IndexOf("dd"), 2);
                _day = Convert.ToInt16(days);



            }





        }
        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }


        public DateTime Englishdate
        {
            get
            {
                return BsoftDateConverter.EnglishDate(new NepaliDate(Year, Month, Day));
            }
            set
            {
                NepaliDate _nepalidate;

                _nepalidate = BsoftDateConverter.NepaliDate(value);
                Year = _nepalidate.Year;
                Month = _nepalidate.Month;
                Day = _nepalidate.Day;


            }
        }
        public NepaliDate nepalidate
        {
            get { return new NepaliDate(Year, Month, Day); }
            set
            {
                Year = value.Year;
                Month = value.Month;
                Day = value.Day;


            }
        }
        public override string ToString()
        {

            return _year.ToString("0000") + "/" + _month.ToString("00") + "/" + _day.ToString("00");
        }
        public string ToString(Boolean unicode, string format)
        {
            if (!unicode)
                return ToString(format);
            else
                return Bsoft.Date.generalNepaliFunctions.getUnicodeNepali(ToString(format));

        }
        public string ToString(string format)
        {
            string dt = "";
            dt = format.ToLower();
            dt = dt.Replace("yyyy", Year.ToString("0000"));
            dt = dt.Replace("mm", Month.ToString("00"));
            dt = dt.Replace("month", Bsoft.Date.generalNepaliFunctions.getFullMonthName(Month, generalNepaliFunctions.NeplaiMonthFormat.Nepali));
            dt = dt.Replace("dd", Day.ToString("00"));
            return dt;
        }

        public bool Equals(NepaliDate d1)
        {
            if (d1.Year == Year & d1.Month == Month & d1.Day == Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TimeSpan operator -(NepaliDate d1, NepaliDate d2)
        {
            DateTime e1 = d1.Englishdate;
            DateTime e2 = d2.Englishdate;
            return  e1-e2;
        }
        public static NepaliDate operator +(NepaliDate d1, TimeSpan ts)
        {
            DateTime e1 = d1.Englishdate;
            DateTime e2 = e1 + ts;
            return new NepaliDate(e2);
        }
        public static NepaliDate operator +(TimeSpan ts, NepaliDate d1)
        {
            DateTime e1 = d1.Englishdate;
            DateTime e2 = e1 + ts;
            return new NepaliDate(e2);
        }
        public static string  About
        {
            get {
                return "Algorithm and design developed by \n Dhiraj Bajracharya \n mrdhiraj@gmail.com took some 3 months in year 2011";
            }
        }
        public static string Liscencedto
        {
            get
            {
                return "Not Liscenced";
            }

        }
    }

}

