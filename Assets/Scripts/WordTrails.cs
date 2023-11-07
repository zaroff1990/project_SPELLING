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
    "b e g",
    "l e g",
    "l e t",
    "l e d",
    "b e d",
    "w e d",
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
    "b o b",
    "j o b",
    "j o t",
    "l o t",
    "h o t",
    "h o g",
    "d o g",
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
    "r e d",
    "r e p",
    "p e p",
    "p u p",
    "c u p",
    "c a p",
    "r a p",
    "n a p",
    "t a x",
    "t a x",
    };
    [HideInInspector]
    public string[] diagraph1 = new string[]
    {
    "m u g",
    "d u g",
    "l u g",
    "l u ck",
    "t u ck",
    "t u x",
    "t a x",
    "t a p",
    "t o p",
    "sh o p",
    };

    [HideInInspector]
    public string[] diagraph2 = new string[]
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
    public string[] diagraph3 = new string[]
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
    public string[] diagraph4 = new string[]
    {
    "c a sh",
    " c a m",
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
    public string[] diagraph5 = new string[]
    {
    "w i sh",
    "d i sh",
    "d a sh",
    "m a sh",
    "m e sh",
    "m e t",
    "m a t",
    "ch a t",
    "s a t",
    "s a ck",
    };

    [HideInInspector]
    public string[] diagraph6 = new string[]
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
    public string[] diagraph7 = new string[]
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
    public string[] diagraph8 = new string[]
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
    public string[] diagraph9 = new string[]
    {
    "m a th",
    "p a th",
    "p a t ",
    "ch a t",
    "ch a p",
    "t a p",
    "t a ck",
    "r a ck",
    "r a sh",
    "r u sh",
    };

    [HideInInspector]
    public string[] diagraph10 = new string[]
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
    "s ap ",
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
    "d o ll",
    "d o g",
    "j o g",
    "j u g",
    "ch u g",
    "th u g",
    "r u g",
    "r u ff",
    "p u ff",
    "c u ff",
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
    public string[] consonateInit1 = new string[]
    {
    "c r a b",
    "d r a b",
    "g r a b",
    "g r a d",
    "g r a ss",
    "g l a ss",
    "g l o ss",
    "l o ss",
    "l e ss",
    "m e ss",
    };

    [HideInInspector]
    public string[] consonateInit2 = new string[]
    {
    "f r o th",
    "f r o ck",
    "f r o g",
    "f l o g",
    "f l o ck",
    "f l o ss",
    "l o ss",
    "l o ck",
    "c l o ck",
    "c l o g",
    };

    [HideInInspector]
    public string[] consonateInit3 = new string[]
    {
    "n a b",
    "j a b",
    "j a zz",
    "J a ck",
    "y a ck",
    "s a ck",
    "s n a ck",
    "s n a p",
    "s n a g",
    "s t a g",
    };

    [HideInInspector]
    public string[] consonateInit4 = new string[]
    {
    "s p a m",
    "s l a m",
    "s l a b",
    "s l a g",
    "s n a g",
    "s w a g",
    "s w a m",
    "s w i m",
    "s l i m",
    "s l u m",
    };

    [HideInInspector]
    public string[] consonateInit5 = new string[]
    {
    "p a ck",
    "p e ck",
    "s p e ck",
    "s p e ll",
    "s m e ll",
    "s e ll",
    "s w e ll",
    "d w e ll",
    "w e ll",
    "d e ll",
    };

    [HideInInspector]
    public string[] consonateInit6 = new string[]
    {
    "s t i ck",
    "s l i ck",
    "l i ck",
    "c l i ck",
    "c l i p",
    "s l i p",
    "s l o p",
    "s t o p",
    "s t o ck",
    "s o ck",
    };

    [HideInInspector]
    public string[] consonateInit7 = new string[]
    {
    "s l o p",
    "s l a p",
    "c l a p",
    "c a p",
    "c a b",
    "c r a b",
    "d r a b",
    "d r a g",
    "b r a g",
    "b r a ss",
    };

    [HideInInspector]
    public string[] consonateInit8 = new string[]
    {
    "s l i d",
    "s l i m",
    "s l i ck",
    "s t i ck",
    "s t u ck",
    "s t u  b",
    "s u b",
    "r u b",
    "g r u b",
    "g r a b",
    };

    [HideInInspector]
    public string[] consonateInit9 = new string[]
    {
    "d r a g",
    "c r a g",
    "c r a sh",
    "c r a ss",
    "g r a ss",
    "g r a m",
    "g r i m",
    "p r i m",
    "r i m",
    "h i m",
    };

    [HideInInspector]
    public string[] consonateInit10 = new string[]
    {
    "s m a ck",
    "s n a ck",
    "s t a ck",
    "s t i ck",
    "s l i ck",
    "s l i m",
    "s k i m",
    "s k i n",
    "s k i d",
    "s l i d",
    };
    [HideInInspector]
    public string[] consonateFinal1 = new string[]
    {
    "d u s k",
    "t u s k",
    "t a s k",
    "a s k",
    "m a s k",
    "m a s t",
    "l a s t",
    "l o s t",
    "c o s t",
    "c a s t"
    };

    [HideInInspector]
    public string[] consonateFinal2 = new string[]
    {
    "r e n t",
    "b e n t",
    "b e n ch",
    "b e l ch",
    "b e l t",
    "b e s t",
    "r e s t",
    "ch e s t",
    "b e s t",
    "b e n t",
    };

    [HideInInspector]
    public string[] consonateFinal3 = new string[]
    {
    "l i f t",
    "l i n t",
    "h i n t",
    "m i n t",
    "m i s t",
    "m i t",
    "m i d",
    "m i n d",
    "b i n d",
    "b i n ",
    };

    [HideInInspector]
    public string[] consonateFinal4 = new string[]
    {
    "b e n t",
    "t e n t",
    "t e s t",
    "t e x t",
    "n e x t",
    "n e s t",
    "w e s t",
    "w e n t",
    "w e p t",
    "k e p t",
    };

    [HideInInspector]
    public string[] consonateFinal5 = new string[]
    {
    "b u n ch",
    "b u n",
    "b u ck",
    "b u zz",
    "b u d",
    "b u b",
    "b u l b",
    "b u l k",
    "s u l k",
    "s i l k",
    };

    [HideInInspector]
    public string[] consonateFinal6 = new string[]
    {
    "r a n t",
    "p a n t",
    "a n t",
    "a c t",
    "f a c t",
    "f a s t",
    "f i s t",
    "l i s t",
    "l i f t",
    "l e f t",
    };

    [HideInInspector]
    public string[] consonateFinal7 = new string[]
    {
    "t a s k",
    "a s k",
    "m a s k",
    "m a s t",
    "m i s t",
    "l i s t",
    "l i f t",
    "l i n t",
    "m i n t",
    "h i n t",
    };

    [HideInInspector]
    public string[] consonateFinal8 = new string[]
    {
    "c o l d",
    "c o l t",
    "m o l t",
    "m o l d",
    "o l d",
    "g o l d",
    "h o l d",
    "h e l d",
    "h e l p",
    "k e l p",
    };

    [HideInInspector]
    public string[] consonateFinal9 = new string[]
    {
    "w i s p",
    "l i s p",
    "l i s t",
    "l a s t",
    "f a s t",
    "c a s t",
    "p a s t",
    "p e s t",
    "p e l t",
    "f e l t",
    };

    [HideInInspector]
    public string[] consonateFinal10 = new string[]
    {
    "m i l k",
    "s i l k",
    "s i l t",
    "s i f t",
    "l i f t",
    "l e f t",
    "l o f t",
    "l o s t",
    "c o s t",
    "c a s t",
    };
    [HideInInspector]
    public string[] consonateBlend1 = new string[]
    {
    "c l a s p",
    "c l a m p",
    "l a m p",
    "r a m p",
    "c r a m p",
    "c r a m",
    "c r a ck",
    "t r a ck",
    "t r i ck",
    "b r i ck"
    };

    [HideInInspector]
    public string[] consonateBlend2 = new string[]
    {
    "b l ank",
    "b ank",
    "b unk",
    "s unk",
    "s t unk",
    "s t ink",
    "s ink",
    "r ink",
    "d r ink",
    "sh r ink",
    };

    [HideInInspector]
    public string[] consonateBlend3 = new string[]
    {
    "b ank",
    "b l ank",
    "c l ank",
    "c r ank",
    "r ank",
    "s ank",
    "s t ank",
    "t ank",
    "r ank",
    "f r ank",
    };

    [HideInInspector]
    public string[] consonateBlend4 = new string[]
    {
    "f l unk",
    "f l ung",
    "f l ing",
    "c l ing",
    "s l ing",
    "s l ink",
    "s t ink",
    "s t ing",
    "s t r ing",
    "s t r ong",
    };

    [HideInInspector]
    public string[] consonateBlend5 = new string[]
    {
    "s t r u ck",
    "t r u ck",
    "t u ck",
    "p u ck",
    "p l u ck",
    "p l u g",
    "s l u g",
    "s l u m",
    "s l u m p",
    "c l u m p",
    };

    [HideInInspector]
    public string[] consonateBlend6 = new string[]
    {
    "l a sh",
    "s l a sh",
    "s p l a sh",
    " s l a sh",
    "c l a sh",
    "c l a s p",
    "g r a s p",
    "g r a s s",
    "c r a s s",
    "c l a s s",
    };

    [HideInInspector]
    public string[] consonateBlend7 = new string[]
    {
    "s p l a t",
    "s l a t",
    "s c a t",
    "s c a n",
    "c a n",
    "b a n",
    "b a n d",
    "s a n d",
    "s t a n d",
    "s t r a n d",
    };

    [HideInInspector]
    public string[] consonateBlend8 = new string[]
    {
    "s p l a t",
    "s l a t",
    "s l a sh",
    "s l u sh",
    "f l u sh",
    "f l a sh",
    "c l a sh",
    "c r a sh",
    "c r a ck",
    "c r o ck",
    };

    [HideInInspector]
    public string[] consonateBlend9 = new string[]
    {
    "s t r i p",
    "s t r a p",
    "t r a p",
    "r a p",
    "r i p",
    "t r i p",
    "t r a p",
    "t r a sh",
    "t r a ck",
    "r a ck",
    };

    [HideInInspector]
    public string[] consonateBlend10 = new string[]
    {
    "b i n d",
    "b l i n d",
    "b l o n d",
    "b l e n d",
    "l e n d",
    "s e n d",
    "s e n t",
    "s p e n t",
    "p e n t",
    "p e n d",
    };
    [HideInInspector]
    public string[] syllables1 = new string[]
{
    "sh e d",
    "sh e  ",
    "b e",
    "b e d",
    "b i d",
    "h i d",
    "h i  ",
    "h i m",
    "h i t",
    "s i t",
};

    [HideInInspector]
    public string[] syllables2 = new string[]
    {
    "g o t",
    "g o ",
    "g o sh",
    "n o sh",
    "n o ",
    "n o t",
    "p o t",
    "p e t",
    "w e t",
    "w e ",
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
    "sh e",
    "sh e d",
    "b ed",
    "b e ",
    "b e t",
    "m e t",
    " m e",
    "m e n",
    "h e n",
    "h e ",
    };

    [HideInInspector]
    public string[] syllables5 = new string[]
    {
    "s o",
    "s o b",
    "g o b",
    "g o ",
    "g e t",
    "w e t",
    "w e ",
    "w e d",
    "b e d",
    "b e ",
    };

    [HideInInspector]
    public string[] syllables6 = new string[]
    {
    "n o t",
    "n o ",
    "n o d",
    "b o d",
    "b e d",
    " b e",
    "sh e",
    "sh e d",
    "r e d",
    "l e d",
    };

    [HideInInspector]
    public string[] syllables7 = new string[]
    {
    "m e t",
    "m e ",
    "w e",
    "w e t",
    "g e t",
    "n e t",
    "n o t",
    "n o  ",
    "g o ",
    "g o t",
    };

    [HideInInspector]
    public string[] syllables8 = new string[]
    {
    "g o t",
    "g o",
    "g o b",
    "s o b",
    "s o ",
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
    "m e ",
    "m e n",
    "h e n",
    "h e",
    "b e ",
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
    "sh y",
    "sh e  ",
    "sh e d",
    "b e d ",
    "b e",
    "b y",
    "wh y",
    "m y",
    };
    [HideInInspector]
    public string[] silentE1 = new string[]
    {
    "t a p",
    "t a p e",
    "c a p e",
    "c a p ",
    "cl a p",
    "c l i p",
    "l i p",
    "s i p",
    "s i t",
    "s i t e",
    };

    [HideInInspector]
    public string[] silentE2 = new string[]
    {
    "k i t e",
    "k i t ",
    "f i t",
    "b i t",
    "b i t e",
    "s i t e",
    "qu i t e",
    "qu i t ",
    "qu i z",
    "b i z",
    };

    [HideInInspector]
    public string[] silentE3 = new string[]
    {
    "p i n e",
    "p i n ",
    "f i n",
    "f i n e",
    "l i n e",
    "l i k e",
    "b i k e",
    "p i k e",
    "p i l e",
    "m i l e",
    };

    [HideInInspector]
    public string[] silentE4 = new string[]
    {
    "c a k e",
    "l a k e",
    "l a t e",
    "m a t e",
    "m a l e",
    "m o l e",
    "m i l e",
    "m i ll",
    "p i ll",
    "f i ll",
    };

    [HideInInspector]
    public string[] silentE5 = new string[]
    {
    "m a d e",
    "f a d e",
    "f a k e",
    "l a k e",
    "l i k e",
    "p i k e",
    "p i n e",
    "f i n e",
    "f i n ",
    "f i n d",
    };

    [HideInInspector]
    public string[] silentE6 = new string[]
    {
    "c a p",
    "c a p e",
    "c a n e",
    "c a n ",
    "m a n",
    "m a n e",
    "l a n e",
    "l a k e",
    "l a m e",
    "s a m e",
    };

    [HideInInspector]
    public string[] silentE7 = new string[]
    {
    "f a n",
    "c a n ",
    "c a n e",
    "c a m e",
    "s a m e",
    "s a v e",
    "w a v e",
    "p a v e",
    "p a l e",
    "p a l ",
    };

    [HideInInspector]
    public string[] silentE8 = new string[]
    {
    "i c e",
    "d i c e",
    "d i m e",
    "d o m e",
    "h o m e",
    "h o l e",
    "p o l e",
    "m o l e",
    "m o d e",
    "m o p e",
    };

    [HideInInspector]
    public string[] silentE9 = new string[]
    {
    "r i c e",
    "n i c e",
    "i c e",
    "a c e",
    "r a c e",
    "r a k e",
    "t a k e",
    "t a l e",
    "s a l e",
    "k a le",
    };

    [HideInInspector]
    public string[] silentE10 = new string[]
    {
    "c a g e",
    "a g e",
    "p a g e",
    "p a c e",
    "p l a c e",
    "l a c e",
    "l a k e",
    "f a k e",
    "f a c e",
    "f a c t",
    };
    [HideInInspector]
    public string[] bossyR1 = new string[]
    {
    "b ar",
    "c ar",
    "c ar t",
    "ar t",
    "m ar t",
    "t ar t",
    "s t ar t",
    "s t ar ",
    "s t ir",
    "s ir",
    };

    [HideInInspector]
    public string[] bossyR2 = new string[]
    {
    "y ur t",
    "c ur t",
    "c ur l",
    "c ur b",
    "c ar b",
    "c ar ",
    "f ar",
    "f ar m",
    "h ar m",
    "h ar d",
    };

    [HideInInspector]
    public string[] bossyR3 = new string[]
    {
    "m ar k",
    "p ar k",
    "l ar k",
    "l ur k",
    "l ur ch",
    "ch ur ch",
    "ch ur n",
    "t ur n",
    "t ur f",
    "s ur f",
    };

    [HideInInspector]
    public string[] bossyR4 = new string[]
    {
    "b ur p",
    "b ur n",
    "b ar n",
    "b ar ",
    "b ar k",
    "p ar k",
    "p ar ",
    "f ar",
    "f ar m",
    "h ar m",
    };

    [HideInInspector]
    public string[] bossyR5 = new string[]
    {
    "th or n",
    "b or n",
    "b ar n",
    "b ar ",
    "b ar f",
    "b ar d",
    "h ar d",
    "c ar d",
    "c ar b",
    "b ar b",
    };

    [HideInInspector]
    public string[] bossyR6 = new string[]
    {
    "th ir d",
    "b ir d",
    "b ir th",
    "b a th",
    "b a d",
    "h a d",
    "h ar d",
    "h er d",
    "h er ",
    "h e",
    };

    [HideInInspector]
    public string[] bossyR7 = new string[]
    {
    "c ar",
    "f ar",
    "f or",
    "f or m",
    "n or m",
    "n or ",
    "f or",
    "f or k",
    "c or k",
    "c or n",
    };

    [HideInInspector]
    public string[] bossyR8 = new string[]
    {
    "s ur f",
    "t ur f",
    "t ur n",
    "b ur n",
    "b or n",
    "c or n",
    "c or k",
    "p or k",
    "p or t",
    "s or t",
    };

    [HideInInspector]
    public string[] bossyR9 = new string[]
    {
    "b ar n",
    "b ar k",
    "p ar k",
    "p ar t",
    "p or t",
    "f or t",
    "f or ",
    "f or k",
    "c or k",
    "c or d",
    };

    [HideInInspector]
    public string[] bossyR10 = new string[]
    {
    "m ar k",
    "m ar t",
    "t ar t",
    "s t ar t",
    "s t ar ",
    "t ar ",
    "t ar p",
    "h ar p",
    "h ar m",
    "f ar m",
    };
    [HideInInspector]
    public string[] vowel1 = new string[]
    {
    "b ee",
    "s ee",
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
    public string[] vowel2 = new string[]
    {
    "s ea",
    "t ea",
    "t ea m",
    "s t ea m",
    "s ea m",
    "s ea t",
    "h ea t",
    "b ea t",
    "b ea m",
    "b ea d",
    };

    [HideInInspector]
    public string[] vowel3 = new string[]
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
    public string[] vowel4 = new string[]
    {
    "d ay",
    "h ay",
    "s ay",
    "s w ay",
    "s t ay",
    "s ay",
    "p ay",
    "l ay",
    "p l ay",
    "c l ay",
    };

    [HideInInspector]
    public string[] vowel5 = new string[]
    {
    "h igh",
    "s igh",
    "s igh t",
    "s i t",
    "f i t",
    "f igh t",
    "l igh t",
    "f l igh t",
    "f l ee t",
    "f ee t",
    };

    [HideInInspector]
    public string[] vowel6 = new string[]
    {
    "b oa t",
    "oa t",
    "c oa t",
    "c oa s t",
    "b oa s t",
    "b oa t",
    "g oa t",
    "g oa l",
    "c oa l",
    "c oa t",
    };

    [HideInInspector]
    public string[] vowel7 = new string[]
    {
    "t oe",
    "t ow",
    "l ow",
    "s l ow",
    "b l ow",
    "b ow",
    "r ow",
    "sh ow",
    "sh ow n",
    "t ow n",
    };

    [HideInInspector]
    public string[] vowel8 = new string[]
    {
    "s oo n",
    "m oo n",
    "m oo d",
    "f oo d",
    "f oo l",
    "p oo l",
    "t oo l",
    "s t oo l",
    "s t ee l",
    "s t ee p",
    };

    [HideInInspector]
    public string[] vowel9 = new string[]
    {
    "s oo n",
    "s p oo n",
    "s p oo k",
    "s p oo l",
    "p oo l",
    "t oo l",
    "t ai l",
    "n ai l",
    "s n ai l",
    "s ai l",
    };

    [HideInInspector]
    public string[] vowel10 = new string[]
    {
    "d r ew",
    "d ew",
    "f ew",
    "f l ew",
    "b l ew",
    "b l ue",
    "c l ue",
    "c l ay",
    "p l ay",
    "p ay",
    };
    [HideInInspector]
    public string[] tricky1 = new string[]
    {
    "sh oo t",
    "sh ou t",
    "ou t",
    "p ou t",
    "t ou t",
    "l ou t",
    "g ou t",
    "g r ou t",
    "t r ou t",
    "t r ea t",
    };

    [HideInInspector]
    public string[] tricky2 = new string[]
    {
    "c oo k",
    "c oo l",
    "t oo l",
    "t oo k",
    "r oo k",
    "c r oo k",
    "b r oo k",
    "b oo k",
    "b ee k",
    "s ee k",
    };

    [HideInInspector]
    public string[] tricky3 = new string[]
    {
    "p oi n t",
    "j oi n t",
    "j oi n",
    "c oi n",
    "c oi l",
    "oi l",
    "f oi l",
    "f oo l",
    "f ue l",
    "d ue l",
    };

    [HideInInspector]
    public string[] tricky4 = new string[]
    {
    "t ow n",
    "g ow n",
    "d ow n",
    "d r ow n",
    "f r ow n",
    "c r ow n",
    "c l ow n",
    "c r ow n",
    "c r ow",
    "g r ow",
    };

    [HideInInspector]
    public string[] tricky5 = new string[]
    {
    "m ou n t",
    "m ou n d",
    "b ou n d",
    "b o n d",
    "f o n d",
    "f ou n d",
    "s ou n d",
    "w ou n d",
    "p ou n d",
    "p o n d",
    };

    [HideInInspector]
    public string[] tricky6 = new string[]
    {
    "b oy",
    "j oy",
    "s oy",
    "t oy",
    "t ee",
    "t ee th",
    "t oo th",
    "b oo th",
    "b oo k",
    "t oo k",
    };

    [HideInInspector]
    public string[] tricky7 = new string[]
    {
    "c l aw",
    "l aw",
    "s l aw",
    "s aw",
    "j aw",
    "p aw",
    "p aw n",
    "l aw n",
    "l aw",
    "f l aw",
    };

    [HideInInspector]
    public string[] tricky8 = new string[]
    {
    "h oo d",
    "h ea d",
    "b ea d",
    "b r ea d",
    "r ea d",
    "r ea l",
    "r ai l",
    "t r ai l",
    "t ai l",
    "t oo l",
    };

    [HideInInspector]
    public string[] tricky9 = new string[]
    {
    "s ea l",
    "s t ea l",
    "t ea l",
    "v ea l",
    "v ei l",
    "v ei n",
    "r ei n",
    "r ai n",
    "g r ai n",
    "g r oa n",
    };

    [HideInInspector]
    public string[] tricky10 = new string[]
    {
    "m ou th",
    "s ou th",
    "s ou r",
    "ou r",
    "ou t",
    "b ou t",
    "b oo t",
    "f oo t",
    "f oo d",
    "g oo d",
    };



}
