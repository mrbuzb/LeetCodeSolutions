namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sss = new Solution();
            Console.WriteLine(sss.CountCharacters(["cat", "bt", "hat", "tree"], "atach"));
        }
    }


    public class Solution
    {
        //1160
        public int CountCharacters(string[] words, string chars)
        {
            var result = 0;
            var checker = true;
            foreach(var word in words)
            {
                foreach(var ch in word)
                {
                    if(chars.Count(x=>x == ch) >= word.Count(x=>x == ch))
                    {
                        continue;
                    }
                    else
                    {
                        checker = false;
                        break;
                    }
                }
                if (checker) result += word.Length;
                checker = true;
            }
            return result;
        }
    }

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
