using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WordTrails : MonoBehaviour
{

    [HideInInspector]
    public string[] alphabet = new string[]
    {
        "a", "A",
        "b", "B",
        "c", "C",
        "d", "D",
        "e", "E",
        "f", "F",
        "g", "G",
        "h", "H",
        "i", "I",
        "j", "J",
        "k", "K",
        "l", "L",
        "m", "M",
        "n", "N",
        "o", "O",
        "p", "P",
        "q", "Q",
        "r", "R",
        "s", "S",
        "t", "T",
        "u", "U",
        "v", "V",
        "w", "W",
        "x", "X",
        "y", "Y",
        "z", "Z"
    };
    [HideInInspector] public string[] trailA = new string[]
{
    "cat",
    "bat",
    "hat",
    "had",
    "bad",
    "sad",
    "sat",
    "fat",
    "mat",
    "mad",
};

    [HideInInspector]
    public string[] cvc1 = new string[]
    {
    "c a t",
    "b a t",
    "h a t",
    "h a d",
    "b a d",
    "s a d",
    "s a t",
    "f a t",
    "m a t",
    "m a d",
    };

    [HideInInspector]
    public string[] cvc2 = new string[]
    {
    "p e p",
    "p e n",
    "p e t",
    "b e t",
    "g e t",
    "m e t",
    "v e t",
    "s e t",
    "n e t",
    "l e t",
    };

    [HideInInspector]
    public string[] cvc3 = new string[]
    {
    "t i p",
    "p i p",
    "p i t",
    "m i t",
    "f i t",
    "f i n",
    "w i n",
    "b i n",
    "b i g",
    "d i g",
    };

    [HideInInspector]
    public string[] cvc4 = new string[]
    {
    "p o t",
    "g o t",
    "b o t",
    "B o b",
    "j o b",
    "j o t",
    "l o t",
    "h o t",
    "r o t",
    "n o t",
    };

    [HideInInspector]
    public string[] cvc5 = new string[]
    {
    "h u b",
    "n u b",
    "n u n",
    "f u n",
    "b u n",
    "r u n",
    "r u g",
    "j u g",
    "t u g",
    "t u b",
    };

    [HideInInspector]
    public string[] cvc6 = new string[]
    {
    "n a p",
    "m a p",
    "c a p",
    "s a p",
    "s a g",
    "s a d",
    "l a d",
    "l i d",
    "l i p",
    "l a p",
    };

    [HideInInspector]
    public string[] cvc7 = new string[]
    {
    "l e d",
    "l e t",
    "n e t",
    "v e t",
    "m e t",
    "p e t",
    "s e t",
    "s i t",
    "l i t",
    "k i t",
    };

    [HideInInspector]
    public string[] cvc8 = new string[]
    {
    "d a b",
    "l a b",
    "l a p",
    "l o p",
    "p o p",
    "t o p",
    "t a p",
    "y a p",
    "y i p",
    "t i p",
    };

    [HideInInspector]
    public string[] cvc9 = new string[]
    {
    "h a d",
    "l a d",
    "l e d",
    "l e g",
    "l u g",
    "r u g",
    "m u g",
    "t u g",
    "t a g",
    "t a x",
    };

    [HideInInspector]
    public string[] cvc10 = new string[]
    {
    "R e x",
    "r e p",
    "p e p",
    "p u p",
    "c u p",
    "c a p",
    "r a p",
    "n a p",
    "t a p",
    "t a x",
    };

    [HideInInspector]
    public string[] digraph1 = new string[]
    {
    "s u b",
    "h u b",
    "s u b",
    "s u ck",
    "t u ck",
    "t u x",
    "t a x",
    "t a p",
    "t o p",
    "sh o p",
    };

    [HideInInspector]
    public string[] digraph2 = new string[]
    {
    "z a p",
    "t a p",
    "t o p",
    "t i p",
    "wh i p",
    "sh i p",
    "y i p",
    "y a p",
    "ch a p",
    "ch o p",
    };

    [HideInInspector]
    public string[] digraph3 = new string[]
    {
    "d a sh",
    "g a sh",
    "g a b",
    "g a l",
    "g a p",
    "t a p",
    "ch a p",
    "ch i p",
    "sh i p",
    "t i p",
    };

    [HideInInspector]
    public string[] digraph4 = new string[]
    {
    "c a sh",
    "c a m",
    "y a m",
    "h a m",
    "h a g",
    "t a g",
    "t a n",
    "t a ck",
    "s a ck",
    "S a m",
    };

    [HideInInspector]
    public string[] digraph5 = new string[]
    {
    "w i sh",
    "d i sh",
    "d a sh",
    "m a sh",
    "m e sh",
    "m e t",
    "m a t",
    "c h at",
    "s a t",
    "s a ck",
    };

    [HideInInspector]
    public string[] digraph6 = new string[]
    {
    "h e m",
    "th e m",
    "th e n",
    "th i n",
    "sh i n",
    "sh i p",
    "d i p",
    "d i m",
    "r i m",
    "r i ch",
    };

    [HideInInspector]
    public string[] digraph7 = new string[]
    {
    "c a sh",
    "s a sh",
    "s a ck",
    "s i ck",
    "th i ck",
    "th i n",
    "th e n",
    "th a n",
    "r a n",
    "r a sh",
    };

    [HideInInspector]
    public string[] digraph8 = new string[]
    {
    "ch a p",
    "t a p",
    "t o p",
    "sh o p",
    "sh i p",
    "d i p",
    "d i sh",
    "f i sh",
    "f i n",
    "sh i n",
    };

    [HideInInspector]
    public string[] digraph9 = new string[]
    {
    "m a th",
    "p a th",
    "p a t",
    "ch a t",
    "ch a p",
    "t a p",
    "t a ck",
    "r a ck",
    "r a sh",
    "r u sh",
    };

    [HideInInspector]
    public string[] digraph10 = new string[]
    {
    "b a sh",
    "s a sh",
    "l a sh",
    "l a p",
    "l i p",
    "s i p",
    "sh i p",
    "sh i n",
    "t i n",
    "w i n",
    };

    [HideInInspector]
    public string[] floss1 = new string[]
    {
    "s a p",
    "s a ck",
    "s i ck",
    "th i ck",
    "N i ck",
    "l i ck",
    "M i ck",
    "m i t",
    "m i ll",
    "f i ll",
    };

    [HideInInspector]
    public string[] floss2 = new string[]
    {
    "th e n",
    "wh e n",
    "K e n",
    "m e n",
    "m e ss",
    "m e sh",
    "m a sh",
    "m a ss",
    "p a ss",
    "p a th",
    };

    [HideInInspector]
    public string[] floss3 = new string[]
    {
    "d o t",
    "d o g",
    "j o g",
    "j u g",
    "ch u g",
    "th u g",
    "l u g",
    "r u g",
    "r u n",
    "r u ff",
    };

    [HideInInspector]
    public string[] floss4 = new string[]
    {
    "d u ck",
    "ch u ck",
    "t u ck",
    "y u ck",
    "sh u ck",
    "l u ck",
    "l u sh",
    "l u ll",
    "g u ll",
    "d u ll",
    };

    [HideInInspector]
    public string[] floss5 = new string[]
    {
    "k i ss",
    "m i ss",
    "m e ss",
    "l e ss",
    "l e t",
    "p e t",
    "p i t",
    "p i ll",
    "f i ll",
    "f e ll",
    };

    [HideInInspector]
    public string[] floss6 = new string[]
    {
    "t i n",
    "f i n",
    "f i ll",
    "f i zz",
    "f u zz",
    "b u zz",
    "b u n",
    "b u ff",
    "p u ff",
    "c u ff",
    };

    [HideInInspector]
    public string[] floss7 = new string[]
    {
    "h u ff",
    "p u ff",
    "p u g",
    "p e g",
    "p i g",
    "p i ll",
    "s i ll",
    "s e ll",
    "b e ll",
    "b i ll",
    };

    [HideInInspector]
    public string[] floss8 = new string[]
    {
    "h i ll",
    "h a ll",
    "f a ll",
    "f e ll",
    "t e ll",
    "t i ll",
    "t i p",
    "r i p",
    "r i ff",
    "r u ff",
    };

    [HideInInspector]
    public string[] floss9 = new string[]
    {
    "t o ss",
    "l o ss",
    "l e ss",
    "m e ss",
    "m i ss",
    "m i ll",
    "m a ll",
    "c a ll",
    "f a ll",
    "f e ll",
    };

    [HideInInspector]
    public string[] floss10 = new string[]
    {
    "f i zz",
    "f u zz",
    "b u zz",
    "b u ff",
    "p u ff",
    "p u g",
    "p e g",
    "p i g",
    "p i ll",
    "w i ll",
    };

    [HideInInspector]
    public string[] iConsonate1 = new string[]
    {
    "cr a b",
    "dr a b",
    "gr a b",
    "gr a d",
    "gr a ss",
    "gl a ss",
    "gl o ss",
    "l o ss",
    "l e ss",
    "m e ss",
    };

    [HideInInspector]
    public string[] iConsonate2 = new string[]
    {
    "fr o th",
    "fr o ck",
    "fr o g",
    "fl o g",
    "fl o ck",
    "fl o ss",
    "l o ss",
    "l o ck",
    "cl o ck",
    "cl o g",
    };

    [HideInInspector]
    public string[] iConsonate3 = new string[]
    {
    "n a b",
    "j a b",
    "j a zz",
    "J a ck",
    "y a ck",
    "s a ck",
    "sn a ck",
    "sn a p",
    "sn a g",
    "st a g",
    };

    [HideInInspector]
    public string[] iConsonate4 = new string[]
    {
    "sp a m",
    "sl a m",
    "sl a b",
    "sl a g",
    "sn a g",
    "sw a g",
    "sw a m",
    "sw i m",
    "sl i m",
    "sl u m",
    };

    [HideInInspector]
    public string[] iConsonate5 = new string[]
    {
    "p a ck",
    "p e ck",
    "sp e ck",
    "sp e ll",
    "sm e ll",
    "s e ll",
    "sw e ll",
    "dw e ll",
    "w e ll",
    "d e ll",
    };

    [HideInInspector]
    public string[] iConsonate6 = new string[]
    {
    "st i ck",
    "sl i ck",
    "l i ck",
    "cl i ck",
    "cl i p",
    "sl i p",
    "sl o p",
    "st o p",
    "st o ck",
    "s o ck",
    };

    [HideInInspector]
    public string[] iConsonate7 = new string[]
    {
    "sl o p",
    "sl a p",
    "cl a p",
    "c a p",
    "c a b",
    "cr a b",
    "dr a b",
    "dr a g",
    "br a g",
    "br a ss",
    };

    [HideInInspector]
    public string[] iConsonate8 = new string[]
    {
    "sl i d",
    "sl i m",
    "sl i ck",
    "st i ck",
    "st u ck",
    "st u b",
    "s u b",
    "r u b",
    "gr u b",
    "gr a b",
    };

    [HideInInspector]
    public string[] iConsonate9 = new string[]
    {
    "dr a g",
    "cr a g",
    "cr a sh",
    "cr a ss",
    "gr a ss",
    "gr a m",
    "gr i m",
    "pr i m",
    "r i m",
    "h i m",
    };

    [HideInInspector]
    public string[] iConsonate10 = new string[]
    {
    "sm a ck",
    "sn a ck",
    "st a ck",
    "st i ck",
    "sl i ck",
    "sl i m",
    "sk i m",
    "sk i n",
    "sk i d",
    "sl i d",
    };

    [HideInInspector]
    public string[] fConsonate1 = new string[]
    {
    "a c t",
    "t a ct",
    "t a sk",
    "a s k",
    "m a sk",
    "m a st",
    "l a st",
    "l o st",
    "c o st",
    "c a st",
    };

    [HideInInspector]
    public string[] fConsonate2 = new string[]
    {
    "r en t",
    "b en t",
    "b en ch",
    "b el ch",
    "b el t",
    "b es t",
    "r es t",
    "ch es t",
    "b es t",
    "b en t",
    };

    [HideInInspector]
    public string[] fConsonate3 = new string[]
    {
    "l if t",
    "l in t",
    "h in t",
    "m in t",
    "m is t",
    "m i t",
    "m i d",
    "m in d",
    "b in d",
    "b i n",
    };

    [HideInInspector]
    public string[] fConsonate4 = new string[]
    {
    "b en t",
    "t en t",
    "t es t",
    "t ex t",
    "n ex t",
    "n es t",
    "w es t",
    "w en t",
    "w ep t",
    "k ep t",
    };

    [HideInInspector]
    public string[] fConsonate5 = new string[]
    {
    "b un ch",
    "b u n",
    "b u ck",
    "b u zz",
    "b u d",
    "b u b",
    "b u lb",
    "b u lk",
    "s u lk",
    "s i lk",
    };

    [HideInInspector]
    public string[] fConsonate6 = new string[]
    {
    "r a nt",
    "p a nt",
    "a n t",
    "a c t",
    "f a ct",
    "f a st",
    "f i st",
    "l i st",
    "l i ft",
    "l e ft",
    };

    [HideInInspector]
    public string[] fConsonate7 = new string[]
    {
    "t a sk",
    "a s k",
    "ma sk",
    "m as t",
    "m is t",
    "li s t",
    "li f t",
    "li n t",
    "mi n t",
    "hi n t",
    };

    [HideInInspector]
    public string[] fConsonate8 = new string[]
    {
    "c ol d",
    "c ol t",
    "m ol t",
    "m ol d",
    "o l d",
    "g ol d",
    "h ol d",
    "h el d",
    "h el p",
    "k el p",
    };

    [HideInInspector]
    public string[] fConsonate9 = new string[]
    {
    "w is p",
    "l is p",
    "l is t",
    "l as t",
    "f as t",
    "c as t",
    "p as t",
    "p es t",
    "p el t",
    "f el t",
    };

    [HideInInspector]
    public string[] fConsonate10 = new string[]
    {
    "m il k",
    "s il k",
    "s il t",
    "s if t",
    "l if t",
    "l ef t",
    "l of t",
    "l os t",
    "c os t",
    "c as t",
    };

    [HideInInspector]
    public string[] bConsonate1 = new string[]
    {
    "gr a sp",
    "cl a sp",
    "cl a mp",
    "l a mp",
    "r a mp",
    "cr a mp",
    "cr a m",
    "cr a ck",
    "tr a ck",
    "tr a ct",
    };

    [HideInInspector]
    public string[] bConsonate2 = new string[]
    {
    "bl an k",
    "b an k",
    "b un k",
    "s un k",
    "st un k",
    "st in k",
    "s in k",
    "r in k",
    "dr in k",
    "shr in k",
    };

    [HideInInspector]
    public string[] bConsonate3 = new string[]
    {
    "pl a n",
    "cl a n",
    "cl a ng",
    "sl a ng",
    "s a ng",
    "s a nk",
    "st a nk",
    "t a nk",
    "r a nk",
    "fr a nk",
    };

    [HideInInspector]
    public string[] bConsonate4 = new string[]
    {
    "fl u nk",
    "fl u ng",
    "fl i ng",
    "cl i ng",
    "sl i ng",
    "sl i nk",
    "st i nk",
    "st i ng",
    "str i ng",
    "str o ng",
    };

    [HideInInspector]
    public string[] bConsonate5 = new string[]
    {
    "str u ck",
    "tr u ck",
    "t u ck",
    "p u ck",
    "pl u ck",
    "pl u g",
    "sl u g",
    "sl u ng",
    "l u ng",
    "h u ng",
    };

    [HideInInspector]
    public string[] bConsonate6 = new string[]
    {
    "l a sh",
    "sl a sh",
    "spl a sh",
    "sl a sh",
    "cl a sh",
    "cl a sp",
    "gr a sp",
    "gr a ss",
    "cr a ss",
    "cl a ss",
    };

    [HideInInspector]
    public string[] bConsonate7 = new string[]
    {
    "spl a t",
    "sl a t",
    "sc a t",
    "sc a m",
    "sc a mp",
    "st a mp",
    "st a nd",
    "str a nd",
    "st a nd",
    "s a nd",
    };

    [HideInInspector]
    public string[] bConsonate8 = new string[]
    {
    "spl a t",
    "sl a t",
    "sl a sh",
    "sl u sh",
    "fl u sh",
    "fl a sh",
    "cl a sh",
    "cr a sh",
    "cr a ck",
    "cr o ck",
    };

    [HideInInspector]
    public string[] bConsonate9 = new string[]
    {
    "str i p",
    "str a p",
    "tr a p",
    "r a p",
    "r i p",
    "tr i p",
    "tr a p",
    "tr a sh",
    "tr a ck",
    "r a ck",
    };

    [HideInInspector]
    public string[] bConsonate10 = new string[]
    {
    "b i nd",
    "bl i nd",
    "bl o nd",
    "bl e nd",
    "l e nd",
    "s e nd",
    "s e nt",
    "sp e nt",
    "p e nt",
    "p e nd",
    };

    [HideInInspector]
    public string[] syllables1 = new string[]
    {
    "sh e d",
    "sh e",
    "b e",
    "b e d",
    "b i d",
    "h i d",
    "h i",
    "h i m",
    "h i t",
    "s i t",
    };

    [HideInInspector]
    public string[] syllables2 = new string[]
    {
    "g o t",
    "g o",
    "g o sh",
    "n o sh",
    "n o",
    "n o t",
    "p o t",
    "p e t",
    "w e t",
    "w e",
    };

    [HideInInspector]
    public string[] syllables3 = new string[]
    {
    "h i",
    "h i t",
    "h i m",
    "d i m",
    "h i m",
    "h e m",
    "h i",
    "h i d",
    "h a d",
    "p a d",
    };

    [HideInInspector]
    public string[] syllables4 = new string[]
    {
    "s h e",
    "sh e d",
    "b e d",
    "b e",
    "b e t",
    "m e t",
    "m e",
    "m e n",
    "h e n",
    "h e",
    };

    [HideInInspector]
    public string[] syllables5 = new string[]
    {
    "s o",
    "s o b",
    "g o b",
    "g o",
    "g e t",
    "w e t",
    "w e",
    "w e d",
    "b e d",
    "b e",
    };

    [HideInInspector]
    public string[] syllables6 = new string[]
    {
    "n o t",
    "n o",
    "n o d",
    "b o d",
    "b e d",
    "b e",
    "s h e",
    "sh e d",
    "r e d",
    "l e d",
    };

    [HideInInspector]
    public string[] syllables7 = new string[]
    {
    "m e t",
    "m e",
    "w e",
    "w e t",
    "g e t",
    "n e t",
    "n o t",
    "n o",
    "g o",
    "g o t",
    };

    [HideInInspector]
    public string[] syllables8 = new string[]
    {
    "g o t",
    "g o",
    "g o b",
    "s o b",
    "s o",
    "n o",
    "n o d",
    "g o d",
    "g o",
    "y o",
    };

    [HideInInspector]
    public string[] syllables9 = new string[]
    {
    "m e t",
    "m e",
    "m e n",
    "h e n",
    "h e",
    "b e",
    "b e t",
    "b i t",
    "h i t",
    "h i",
    };

    [HideInInspector]
    public string[] syllables10 = new string[]
    {
    "b e",
    "b y",
    "s h y",
    "s h e",
    "sh e d",
    "b e d",
    "b e",
    "b y",
    "w h y",
    "m y",
    };

    [HideInInspector]
    public string[] silent1 = new string[]
    {
    "t a p",
    "t a pe",
    "c a pe",
    "c a p",
    "cl a p",
    "cl i p",
    "l i p",
    "s i p",
    "s i t",
    "s i te",
    };

    [HideInInspector]
    public string[] silent2 = new string[]
    {
    "k i te",
    "k i t",
    "f i t",
    "b i t",
    "b i te",
    "s i te",
    "qu i te",
    "qu i t",
    "qu i z",
    "b i z",
    };

    [HideInInspector]
    public string[] silent3 = new string[]
    {
    "p i ne",
    "p i n",
    "f i n",
    "f i ne",
    "l i ne",
    "l i ke",
    "b i ke",
    "p i ke",
    "p i le",
    "p i ll",
    };

    [HideInInspector]
    public string[] silent4 = new string[]
    {
    "c a ke",
    "l a ke",
    "l a te",
    "m a te",
    "m a le",
    "m o le",
    "m i le",
    "m i ll",
    "p i ll",
    "f i ll",
    };

    [HideInInspector]
    public string[] silent5 = new string[]
    {
    "m a de",
    "f a de",
    "f a ke",
    "l a ke",
    "l i ke",
    "p i ke",
    "p i ne",
    "f i ne",
    "f i n",
    "f i nd",
    };

    [HideInInspector]
    public string[] silent6 = new string[]
    {
    "c a p",
    "c a pe",
    "c a ne",
    "c a n",
    "m a n",
    "m a ne",
    "l a ne",
    "l a ke",
    "l a me",
    "s a me",
    };

    [HideInInspector]
    public string[] silent7 = new string[]
    {
    "f a n",
    "c a n",
    "c a ne",
    "c a me",
    "s a me",
    "s a ve",
    "w a ve",
    "p a ve",
    "p a le",
    "p a l",
    };

    [HideInInspector]
    public string[] silent8 = new string[]
    {
    "i c e",
    "d i ce",
    "d i me",
    "d o me",
    "h o me",
    "h o le",
    "p o le",
    "m o le",
    "m o de",
    "m a de", // You have 'mode' twice, is this intentional?
    };

    [HideInInspector]
    public string[] silent9 = new string[]
    {
    "r i ce",
    "n i ce",
    "i c e",
    "a c e",
    "r a ce",
    "r a ke",
    "t a ke",
    "t a le",
    "s a le",
    "k a le",
    };

    [HideInInspector]
    public string[] silent10 = new string[]
    {
    "c a ge",
    "a ge",
    "p a ge",
    "p a ce",
    "pl a ce",
    "l a ce",
    "l a ke",
    "f a ke",
    "f a ce",
    "f a ct",
    };

    [HideInInspector]
    public string[] bossy1 = new string[]
    {
    "c a r",
    "c a rt",
    "c a t",
    "m a t",
    "m a rt",
    "t a rt",
    "st a rt",
    "st a r",
    "st i r",
    "s i r",
    };

    [HideInInspector]
    public string[] bossy2 = new string[]
    {
    "y u rt",
    "c u rt",
    "c u rl",
    "c u rb",
    "c a rb",
    "c a r",
    "f a r",
    "f a rm",
    "h a rm",
    "h a rd",
    };

    [HideInInspector]
    public string[] bossy3 = new string[]
    {
    "m a rk",
    "p a rk",
    "l a rk",
    "l u rk",
    "l u rch",
    "ch u rch",
    "ch u rn",
    "t u rn",
    "t u rf",
    "s u rf",
    };

    [HideInInspector]
    public string[] bossy4 = new string[]
    {
    "b u rp",
    "b u rn",
    "b a rn",
    "b a r",
    "b a rk",
    "p a rk",
    "p a r",
    "f a r",
    "f a rm",
    "h a rm",
    };

    [HideInInspector]
    public string[] bossy5 = new string[]
    {
    "th o rn",
    "b o rn",
    "b a rn",
    "b a r",
    "b a n",
    "b a nd",
    "h a nd",
    "h a rd",
    "c a rd",
    "c a rb",
    };

    [HideInInspector]
    public string[] bossy6 = new string[]
    {
    "th i rd",
    "b i rd",
    "b i d",
    "l i d",
    "l a d",
    "l a rd",
    "h a rd",
    "h e rd",
    "h e r",
    "h e",
    };

    [HideInInspector]
    public string[] bossy7 = new string[]
    {
    "c a r",
    "f a r",
    "f o r",
    "f o rm",
    "n o rm",
    "n o r",
    "f o r",
    "f o rk",
    "c o rk",
    "c o rn",
    };

    [HideInInspector]
    public string[] bossy8 = new string[]
    {
    "s u rf",
    "t u rf",
    "t u rn",
    "b u rn",
    "b o rn",
    "c o rn",
    "c o rk",
    "p o rk",
    "p o rt",
    "s o rt",
    };

    [HideInInspector]
    public string[] bossy9 = new string[]
    {
    "b ar n",
    "b ar k",
    "p ar k",
    "p ar t",
    "p or t",
    "f or t",
    "f o r",
    "f or k",
    "c or k",
    "c or d",
    };

    [HideInInspector]
    public string[] bossy10 = new string[]
    {
    "m ar k",
    "m ar t",
    "t ar t",
    "st ar t",
    "st ar",
    "t a r",
    "t ar p",
    "h ar p",
    "h ar m",
    "f ar m",
    };

    [HideInInspector]
    public string[] long1 = new string[]
    {
    "b e e",
    "s e e",
    "s ee n",
    "s ee d",
    "n ee d",
    "f ee d",
    "f ee t",
    "sh ee t",
    "b ee t",
    "b ea t",
    };

    [HideInInspector]
    public string[] long2 = new string[]
    {
    "s e a",
    "t e a",
    "t ea m",
    "st ea m",
    "s ea m",
    "s ea t",
    "h ea t",
    "b ea t",
    "b ea m",
    "b ea d",
    };

    [HideInInspector]
    public string[] long3 = new string[]
    {
    "m ai d",
    "p ai d",
    "p ai n",
    "r ai n",
    "r ai d",
    "r ai l",
    "s ai l",
    "p ai l",
    "m ai l",
    "m ai n",
    };

    [HideInInspector]
    public string[] long4 = new string[]
    {
    "d a y",
    "h a y",
    "s a y",
    "sw a y",
    "st a y",
    "s a y",
    "p a y",
    "l a y",
    "pl a y",
    "cl a y",
    };

    [HideInInspector]
    public string[] long5 = new string[]
    {
    "h i gh",
    "s i gh",
    "si gh t",
    "fi gh t",
    "fli gh t",
    "li gh t",
    "mi gh t",
    "ni gh t",
    "ri gh t",
    "ti gh t",
    };

    [HideInInspector]
    public string[] long6 = new string[]
    {
    "b oa t",
    "o a t",
    "c oa t",
    "c oa st",
    "b oa st",
    "b oa t",
    "g oa t",
    "g oa l",
    "c oa l",
    "c oa t",
    };

    [HideInInspector]
    public string[] long7 = new string[]
    {
    "t o e",
    "t o w",
    "b o w",
    "l o w",
    "sl o w",
    "s o w",
    "b o w",
    "r o w",
    "sh o w",
    "sh o wn",
    };

    [HideInInspector]
    public string[] long8 = new string[]
    {
    "s oo n",
    "m oo n",
    "m oo d",
    "f oo d",
    "f oo l",
    "p oo l",
    "t oo l",
    "st oo l",
    "st ee l",
    "st ee p",
    };

    [HideInInspector]
    public string[] long9 = new string[]
    {
    "s oo n",
    "sp oo n",
    "sp oo k",
    "sp oo l",
    "p oo l",
    "t oo l",
    "t ai l",
    "n ai l",
    "sn ai l",
    "s ai l",
    };

    [HideInInspector]
    public string[] long10 = new string[]
    {
    "dr e w",
    "d e w",
    "f e w",
    "fl e w",
    "bl e w",
    "bl u e",
    "c l ue",
    "c l ay",
    "pl a y",
    "p a y",
    };

    [HideInInspector]
    public string[] tricky1 = new string[]
    {
    "sh oo t",
    "sh ou t",
    "o u t",
    "p ou t",
    "t ou t",
    "l ou t",
    "g ou t",
    "gr ou t",
    "tr ou t",
    "tr ea t",
    };

    [HideInInspector]
    public string[] tricky2 = new string[]
    {
    "sh oo k",
    "c oo k",
    "n oo k",
    "l oo k",
    "r oo k",
    "cr oo k",
    "br oo k",
    "b oo k",
    "b ee k",
    "s ee k",
    };

    [HideInInspector]
    public string[] tricky3 = new string[]
    {
    "po in t",
    "jo in t",
    "jo i n",
    "co i n",
    "co i l",
    "o i l",
    "fo i l",
    "fo o l",
    "f ue l",
    "d ue l",
    };

    [HideInInspector]
    public string[] tricky4 = new string[]
    {
    "t ow n",
    "g ow n",
    "d ow n",
    "dr ow n",
    "fr ow n",
    "cr ow n",
    "cl ow n",
    "cr ow n",
    "cr ow",
    "gr o w",
    };

    [HideInInspector]
    public string[] tricky5 = new string[]
    {
    "ro un d",
    "bo un d",
    "mo un d",
    "fo un d",
    "so un d",
    "ro un d",
    "ho un d",
    "wo un d",
    "p oun d",
    "p on d",
    };

    [HideInInspector]
    public string[] tricky6 = new string[]
    {
    "b o y",
    "j o y",
    "s o y",
    "t o y",
    "t e e",
    "t ee th",
    "t oo th",
    "b oo th",
    "b oo k",
    "t oo k",
    };

    [HideInInspector]
    public string[] tricky7 = new string[]
    {
    "cl a w",
    "l a w",
    "sl a w",
    "s a w",
    "j a w",
    "p a w",
    "p aw n",
    "l aw n",
    "l a w",
    "fl a w",
    };

    [HideInInspector]
    public string[] tricky8 = new string[]
    {
    "h oo d",
    "h ea d",
    "b ea d",
    "br ea d",
    "r ea d",
    "r ea l",
    "r ai l",
    "tr ai l",
    "t ai l",
    "t oo l",
    };

    [HideInInspector]
    public string[] tricky9 = new string[]
    {
    "s ea l",
    "st ea l",
    "t ea l",
    "v ea l",
    "v ei l",
    "v ei n",
    "r ei n",
    "r ai n",
    "gr ai n",
    "gr oa n",
    };

    [HideInInspector]
    public string[] tricky10 = new string[]
    {
    "m ou th",
    "s ou th",
    "s ou r",
    "o u r",
    "o u t",
    "b ou t",
    "b oo t",
    "f oo t",
    "f oo d",
    "g oo d",
    };

}
