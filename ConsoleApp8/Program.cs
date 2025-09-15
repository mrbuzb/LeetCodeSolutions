namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sss = new Solution();
            Console.WriteLine(sss.FindOcurrences("obo jvezipre obo jnvavldde jvezipre jvezipre jnvavldde jvezipre jvezipre jvezipre y jnvavldde jnvavldde obo jnvavldde jnvavldde obo jnvavldde jnvavldde jvezipre", "jnvavldde", "y"));
        }
    }

    public class Solution
    {
        //1078
        public string[] FindOcurrences(string text, string first, string second)
        {
            var result = string.Empty;
            var textArray = text.Split(' ');
            for (int i = 0; i < textArray.Length - 1; i++)
            {
                if (textArray[i] == first && textArray[i + 1] == second && i != textArray.Length - 2)
                {
                    result += textArray[i + 2];
                    result += ' ';
                }
            }
            var finalResult = result.Trim().Split(' ');
            if (finalResult.Length == 1 && finalResult[0] == "") return [];
            return finalResult;
        }
    }



    //public class Solution
    //{
    //    //1108
    //    public string DefangIPaddr(string address)
    //    {
    //        //return address.Replace(".", "[.]");
    //        var result = new StringBuilder();
    //        foreach (var c in address)
    //        {
    //            if (c != '.')
    //            {
    //                result.Append(c);
    //            }
    //            else
    //            {
    //                result.Append("[.]");
    //            }
    //        }
    //        return result.ToString();
    //    }
    //}








    //public class Solution
    //{
    //    //1154
    //    public int DayOfYear(string date)
    //    {
    //        //2019-01-09
    //        var result = int.Parse(date.Substring(date.Length - 2));
    //        var month = int.Parse(date.Substring(date.Length - 5, 2));
    //        var year = int.Parse(date.Substring(0, 4));
    //        switch (month)
    //        {
    //            case 2:
    //                result += 31;
    //                break;
    //            case 3:
    //                result += 31*2-1;
    //                break;
    //            case 4:
    //                result += 31 * 3 - 1;
    //                break;
    //            case 5:
    //                result += 31 * 4 - 2;
    //                break;
    //            case 6:
    //                result += 31 * 5 - 2;
    //                break;
    //            case 7:
    //                result += 31 * 6 - 3;
    //                break;
    //            case 8:
    //                result += 31 * 7 - 3;
    //                break;
    //            case 9:
    //                result += 31 * 8 - 3;
    //                break;
    //            case 10:
    //                result += 31 * 9 - 4;
    //                break;
    //            case 11:
    //                result += 31 * 10 - 4;
    //                break;
    //            case 12:
    //                result += 31 * 11 - 5;
    //                break;
    //        }

    //        if(month > 2)
    //        {
    //            if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
    //            {
    //                result -= 1;
    //            }
    //            else
    //            {
    //                result -= 2;
    //            }
    //        }
    //        return result;
    //    }
    //}



    //public class Solution
    //{
    //    //1160
    //    public int CountCharacters(string[] words, string chars)
    //    {
    //        var result = 0;
    //        var checker = true;
    //        foreach(var word in words)
    //        {
    //            foreach(var ch in word)
    //            {
    //                if(chars.Count(x=>x == ch) >= word.Count(x=>x == ch))
    //                {
    //                    continue;
    //                }
    //                else
    //                {
    //                    checker = false;
    //                    break;
    //                }
    //            }
    //            if (checker) result += word.Length;
    //            checker = true;
    //        }
    //        return result;
    //    }
    //}

    //public class Solution
    //{
    //    //1309
    //    public string FreqAlphabets(string s)
    //    {
    //        var dict = new Dictionary<int, char>()
    //    {
    //        { 1,'a'},
    //        { 2,'b'},
    //        { 3,'c'},
    //        { 4,'d'},
    //        { 5,'e'},
    //        { 6,'f'},
    //        { 7,'g'},
    //        { 8,'h'},
    //        { 9,'i'},
    //        { 10,'j'},
    //        { 11,'k'},
    //        { 12,'l'},
    //        { 13,'m'},
    //        { 14,'n'},
    //        { 15,'o'},
    //        { 16,'p'},
    //        { 17,'q'},
    //        { 18,'r'},
    //        { 19,'s'},
    //        { 20,'t'},
    //        { 21,'u'},
    //        { 22,'v'},
    //        { 23,'w'},
    //        { 24,'x'},
    //        { 25,'y'},
    //        { 26,'z'},
    //    };
    //        var helper = string.Empty;
    //        var res = string.Empty;
    //        var counter = 0;
    //        if(s.EndsWith('#')) counter = s.Length;
    //        else counter = s.Length-1;
    //            for (int i = 0; i < s.Length; i++)
    //            {
    //                if (helper.Length == 2 && s[i] != '#' && s[i + 1] == '#')
    //                {
    //                    res += dict[helper[0] - '0'];
    //                    helper = string.Empty;
    //                    i--;
    //                }
    //                if (helper.Length == 2 && s[i] != '#' && s[i] != '0')
    //                {
    //                    res += dict[helper[0] - '0'];
    //                    res += dict[helper[1] - '0'];
    //                    helper = string.Empty;
    //                    i--;
    //                }
    //                else if (s[i] == '#')
    //                {
    //                    res += dict[int.Parse(helper)];
    //                    helper = string.Empty;
    //                }
    //                else
    //                {
    //                    helper += s[i];
    //                }
    //            }
    //        if (helper.Length == 2)
    //        {
    //            res += dict[helper[0] - '0'];
    //            res += dict[helper[1] - '0'];
    //        }
    //        else if (helper.Length == 1)
    //        {
    //            res += dict[helper[0] - '0'];
    //        }
    //        return res;
    //    }
    //}



    //public class Solution
    //{
    //    public int BalancedStringSplit(string s)
    //    {
    //        var maxCounter = 0;
    //        var counterR = 0;
    //        var counterL = 0;
    //        for (var i = 0; i < s.Length; i++)
    //        {
    //            if (s[i] == 'R')
    //            {
    //                counterR++;
    //            }
    //            else
    //            {
    //                counterL++;
    //            }
    //            if (counterR == counterL)
    //            {
    //                maxCounter++;
    //                counterL = 0;
    //                counterR = 0;
    //            }
    //        }
    //        return maxCounter;
    //    }
    //}

    //public class Solution
    //{
    //    public int FirstUniqChar(string s)
    //    {

    //    }
    //}


    //public class Solution
    //{
    //    public int MaxFreqSum(string s)
    //    {
    //        Dictionary<char, int> mp1 = new Dictionary<char, int>();
    //        Dictionary<char, int> mp2 = new Dictionary<char, int>();
    //        foreach (char ch in s)
    //        {
    //            if (mp1.ContainsKey(ch))
    //            {
    //                mp[ch]++;
    //            }
    //            else
    //            {
    //                mp1[ch] = 1;
    //            }
    //        }
    //        int vowel = 0, consonant = 0;
    //        for (char ch = 'a'; ch <= 'z'; ch++)
    //        {
    //            int count = mp.ContainsKey(ch) ? mp[ch] : 0;
    //            if (IsVowel(ch))
    //            {
    //                vowel = Math.Max(vowel, count);
    //            }
    //            else
    //            {
    //                consonant = Math.Max(consonant, count);
    //            }
    //        }
    //        return vowel + consonant;
    //    }

    //    private bool IsVowel(char c)
    //    {
    //        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    //    }
    //}


    //public class Solution
    //{
    //    public int MaxFreqSum(string s)
    //    {
    //        var counter = 0;
    //        foreach (var ch in s)
    //        {
    //            if (ch != 'e' && ch != 'u' && ch != 'o' && ch != 'a' && ch != 'i')
    //            {
    //                counter++;
    //            }
    //        }
    //        return counter;
    //    }
    //}
}
