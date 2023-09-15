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

    [HideInInspector] public string[] cvc1 = new string[]
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
    [HideInInspector] public string[] cvc2 = new string[]
{
    "pep",
    "pen",
    "pet",
    "bet",
    "get",
    "met",
    "vet",
    "set",
    "net",
    "let",
};
    [HideInInspector] public string[] cvc3 = new string[]
{
    "tip",
    "pip",
    "pit",
    "mit",
    "fit",
    "fin",
    "win",
    "bin",
    "big",
    "dig",
};
    [HideInInspector] public string[] cvc4 = new string[]
{
    "pot",
    "got",
    "bot",
    "Bob",
    "job",
    "jot",
    "lot",
    "hot",
    "rot",
    "not",
};
    [HideInInspector] public string[] cvc5 = new string[]
{
    "hub",
    "nub",
    "nun",
    "fun",
    "bun",
    "run",
    "rug",
    "jug",
    "tug",
    "tub",
};
    [HideInInspector] public string[] cvc6 = new string[]
{
    "nap",
    "map",
    "cap",
    "sap",
    "sag",
    "sad",
    "lad",
    "lid",
    "lip",
    "lap",
};
    [HideInInspector] public string[] cvc7 = new string[]
{
    "led",
    "let",
    "net",
    "vet",
    "met",
    "pet",
    "set",
    "sit",
    "lit",
    "kit",
};
    [HideInInspector] public string[] cvc8 = new string[]
{
    "dab",
    "lab",
    "lap",
    "lop",
    "pop",
    "top",
    "tap",
    "yap",
    "yip",
    "tip",
};
    [HideInInspector] public string[] cvc9 = new string[]
{
    "had",
    "lad",
    "led",
    "leg",
    "lug",
    "rug",
    "mug",
    "tug",
    "tag",
    "tax",
};
    [HideInInspector] public string[] cvc10 = new string[]
{
    "Rex",
    "rep",
    "pep",
    "pup",
    "cup",
    "cap",
    "rap",
    "nap",
    "tap",
    "tax",
};

    [HideInInspector] public string[] digraph1 = new string[]
{
    "sub",
    "hub",
    "sub",
    "suck",
    "tuck",
    "tux",
    "tax",
    "tap",
    "top",
    "shop",
};
    [HideInInspector] public string[] digraph2 = new string[]
{
    "zap",
    "tap",
    "top",
    "tip",
    "whip",
    "ship",
    "yip",
    "yap",
    "chap",
    "chop",
};
    [HideInInspector] public string[] digraph3 = new string[]
    {
    "dash",
    "gash",
    "gab",
    "gal",
    "gap",
    "tap",
    "chap",
    "chip",
    "ship",
    "tip"
    };
[HideInInspector] public string[] digraph4 = new string[]
    {
    "cash",
    "cam",
    "yam",
    "ham",
    "hag",
    "tag",
    "tan",
    "tack",
    "sack",
    "Sam"
    };
    [HideInInspector] public string[] digraph5 = new string[]
    {
    "wish",
    "dish",
    "dash",
    "mash",
    "mesh",
    "met",
    "mat",
    "chat",
    "sat",
    "sack"
    };
    [HideInInspector] public string[] digraph6 = new string[]
    {
    "hem",
    "them",
    "then",
    "thin",
    "shin",
    "ship",
    "dip",
    "dim",
    "rim",
    "rich"
    };
    [HideInInspector] public string[] digraph7 = new string[]
    {
    "cash",
    "sash",
    "sack",
    "sick",
    "thick",
    "thin",
    "then",
    "than",
    "ran",
    "rash"
    };
    [HideInInspector] public string[] digraph8 = new string[]
    {
    "chap",
    "tap",
    "top",
    "shop",
    "ship",
    "dip",
    "dish",
    "fish",
    "fin",
    "shin"
    };
    [HideInInspector] public string[] digraph9 = new string[]
    {
    "math",
    "path",
    "pat",
    "chat",
    "chap",
    "tap",
    "tack",
    "rack",
    "rash",
    "rush"
    };
    [HideInInspector] public string[] digraph10 = new string[]
    {
    "bash",
    "sash",
    "lash",
    "lap",
    "lip",
    "sip",
    "ship",
    "shin",
    "tin",
    "win"
    };


    [HideInInspector] public string[] welded1;
    [HideInInspector] public string[] welded2;
    [HideInInspector] public string[] welded3;
    [HideInInspector] public string[] welded4;
    [HideInInspector] public string[] welded5;
    [HideInInspector] public string[] welded6;
    [HideInInspector] public string[] welded7;
    [HideInInspector] public string[] welded8;
    [HideInInspector] public string[] welded9;
    [HideInInspector] public string[] welded10;

    [HideInInspector] public string[] bonus1;
    [HideInInspector] public string[] bonus2;
    [HideInInspector] public string[] bonus3;
    [HideInInspector] public string[] bonus4;
    [HideInInspector] public string[] bonus5;
    [HideInInspector] public string[] bonus6;
    [HideInInspector] public string[] bonus7;
    [HideInInspector] public string[] bonus8;
    [HideInInspector] public string[] bonus9;
    [HideInInspector] public string[] bonus10;

    [HideInInspector] public string[] ng_nk1;
    [HideInInspector] public string[] ng_nk2;
    [HideInInspector] public string[] ng_nk3;
    [HideInInspector] public string[] ng_nk4;
    [HideInInspector] public string[] ng_nk5;
    [HideInInspector] public string[] ng_nk6;
    [HideInInspector] public string[] ng_nk7;
    [HideInInspector] public string[] ng_nk8;
    [HideInInspector] public string[] ng_nk9;
    [HideInInspector] public string[] ng_nk10;

    [HideInInspector] public string[] initialCons1 = new string[]
    {
        "crab",
        "drab",
        "grab",
        "grad",
        "grass",
        "glass",
        "gloss",
        "loss",
        "less",
        "mess"
    };

    [HideInInspector] public string[] initialCons2 = new string[]
    {
        "froth",
        "frock",
        "frog",
        "flog",
        "flock",
        "floss",
        "loss",
        "lock",
        "clock",
        "clog"
    };

    [HideInInspector] public string[] initialCons3 = new string[]
    {
        "nab",
        "jab",
        "jazz",
        "Jack",
        "yack",
        "sack",
        "snack",
        "snap",
        "snag",
        "stag"
    };

    [HideInInspector] public string[] initialCons4 = new string[]
    {
        "spam",
        "slam",
        "slab",
        "slag",
        "snag",
        "swag",
        "swam",
        "swim",
        "slim",
        "slum"
    };

    [HideInInspector] public string[] initialCons5 = new string[]
    {
        "pack",
        "peck",
        "speck",
        "spell",
        "smell",
        "sell",
        "swell",
        "dwell",
        "well",
        "dell"
    };

    [HideInInspector] public string[] initialCons6 = new string[]
    {
        "stick",
        "slick",
        "lick",
        "click",
        "clip",
        "slip",
        "slop",
        "stop",
        "stock",
        "sock"
    };

    [HideInInspector] public string[] initialCons7 = new string[]
    {
        "slop",
        "slap",
        "clap",
        "cap",
        "cab",
        "crab",
        "drab",
        "drag",
        "brag",
        "brass"
    };

    [HideInInspector] public string[] initialCons8 = new string[]
    {
        "slid",
        "slim",
        "slick",
        "stick",
        "stuck",
        "stub",
        "sub",
        "rub",
        "grub",
        "grab"
    };

    [HideInInspector] public string[] initialCons9 = new string[]
    {
        "drag",
        "crag",
        "crash",
        "crass",
        "grass",
        "gram",
        "grim",
        "prim",
        "rim",
        "him"
    };

    [HideInInspector] public string[] initialCons10 = new string[]
    {
        "smack",
        "snack",
        "stack",
        "stick",
        "slick",
        "slim",
        "skim",
        "skin",
        "skid",
        "slid"
    };

    [HideInInspector] public string[] finalCons1 = new string[]
    {
        "act",
        "tact",
        "task",
        "ask",
        "mask",
        "mast",
        "last",
        "lost",
        "cost",
        "cast"
    };

    [HideInInspector] public string[] finalCons2 = new string[]
    {
        "rent",
        "bent",
        "bench",
        "belch",
        "belt",
        "best",
        "rest",
        "chest",
        "best",
        "bent"
    };

    [HideInInspector] public string[] finalCons3 = new string[]
    {
        "lift",
        "lint",
        "hint",
        "mint",
        "mist",
        "mit",
        "mid",
        "mind",
        "bind",
        "bin"
    };

    [HideInInspector] public string[] finalCons4 = new string[]
    {
        "bent",
        "tent",
        "test",
        "text",
        "next",
        "nest",
        "west",
        "went",
        "wept",
        "kept"
    };

    [HideInInspector] public string[] finalCons5 = new string[]
    {
        "bunch",
        "bun",
        "buck",
        "buzz",
        "bud",
        "bub",
        "bulb",
        "bulk",
        "sulk",
        "silk"
    };

    [HideInInspector] public string[] finalCons6 = new string[]
    {
        "rant",
        "pant",
        "ant",
        "act",
        "fact",
        "fast",
        "fist",
        "list",
        "lift",
        "left"
    };

    [HideInInspector] public string[] finalCons7 = new string[]
    {
        "task",
        "ask",
        "mask",
        "mast",
        "mist",
        "list",
        "lift",
        "lint",
        "mint",
        "hint"
    };

    [HideInInspector] public string[] finalCons8 = new string[]
    {
        "cold",
        "colt",
        "molt",
        "mold",
        "old",
        "gold",
        "hold",
        "held",
        "help",
        "kelp"
    };

    [HideInInspector] public string[] finalCons9 = new string[]
    {
        "wisp",
        "lisp",
        "list",
        "last",
        "fast",
        "cast",
        "past",
        "pest",
        "pelt",
        "felt"
    };

    [HideInInspector] public string[] finalCons10 = new string[]
    {
        "milk",
        "silk",
        "silt",
        "sift",
        "lift",
        "left",
        "loft",
        "lost",
        "cost",
        "cast"
    };

    [HideInInspector] public string[] conoBlend1 = new string[]
    {
        "grasp",
        "clasp",
        "clamp",
        "lamp",
        "ramp",
        "cramp",
        "cram",
        "crack",
        "track",
        "tract"
    };

    [HideInInspector] public string[] conoBlend2 = new string[]
    {
        "blank",
        "bank",
        "bunk",
        "sunk",
        "stunk",
        "stink",
        "sink",
        "rink",
        "drink",
        "shrink"
    };

    [HideInInspector] public string[] conoBlend3 = new string[]
    {
        "plan",
        "clan",
        "clang",
        "slang",
        "sang",
        "sank",
        "stank",
        "tank",
        "rank",
        "frank"
    };

    [HideInInspector] public string[] conoBlend4 = new string[]
    {
        "flunk",
        "flung",
        "fling",
        "cling",
        "sling",
        "slink",
        "stink",
        "sting",
        "string",
        "strong"
    };

    [HideInInspector] public string[] conoBlend5 = new string[]
    {
        "struck",
        "truck",
        "tuck",
        "puck",
        "pluck",
        "plug",
        "slug",
        "slung",
        "lung",
        "hung"
    };

    [HideInInspector] public string[] conoBlend6 = new string[]
    {
        "lash",
        "slash",
        "splash",
        "slash",
        "clash",
        "clasp",
        "grasp",
        "grass",
        "crass",
        "class"
    };

    [HideInInspector] public string[] conoBlend7 = new string[]
    {
        "splat",
        "slat",
        "scat",
        "scam",
        "scamp",
        "stamp",
        "stand",
        "strand",
        "stand",
        "sand"
    };

    [HideInInspector] public string[] conoBlend8 = new string[]
    {
        "splat",
        "slat",
        "slash",
        "slush",
        "flush",
        "flash",
        "clash",
        "crash",
        "crack",
        "crock"
    };

    [HideInInspector] public string[] conoBlend9 = new string[]
    {
        "strip",
        "strap",
        "trap",
        "rap",
        "rip",
        "trip",
        "trap",
        "trash",
        "track",
        "rack"
    };

    [HideInInspector] public string[] conoBlend10 = new string[]
    {
        "bind",
        "blind",
        "blond",
        "blend",
        "lend",
        "send",
        "sent",
        "spent",
        "pent",
        "pend"
    };

    [HideInInspector] public string[] silentE1 = new string[]
    {
        "tap",
        "tape",
        "cape",
        "cap",
        "clap",
        "clip",
        "lip",
        "sip",
        "sit",
        "site"
    };

    [HideInInspector] public string[] silentE2 = new string[]
    {
        "kite",
        "kit",
        "fit",
        "bit",
        "bite",
        "site",
        "quite",
        "quit",
        "quiz",
        "biz"
    };

    [HideInInspector] public string[] silentE3 = new string[]
    {
        "pine",
        "pin",
        "fin",
        "fine",
        "line",
        "like",
        "bike",
        "pike",
        "pile",
        "pill"
    };

    [HideInInspector] public string[] silentE4 = new string[]
    {
        "cake",
        "lake",
        "late",
        "mate",
        "male",
        "mole",
        "mile",
        "mill",
        "pill",
        "fill"
    };

    [HideInInspector] public string[] silentE5 = new string[]
    {
        "made",
        "fade",
        "fake",
        "lake",
        "like",
        "pike",
        "pine",
        "fine",
        "fin",
        "find"
    };

    [HideInInspector] public string[] silentE6 = new string[]
    {
        "cap",
        "cape",
        "cane",
        "can",
        "man",
        "mane",
        "lane",
        "lake",
        "lame",
        "same"
    };

    [HideInInspector] public string[] silentE7 = new string[]
    {
        "fan",
        "can",
        "cane",
        "came",
        "same",
        "save",
        "wave",
        "pave",
        "pale",
        "pal"
    };

    [HideInInspector] public string[] silentE8 = new string[]
    {
        "ice",
        "dice",
        "dime",
        "dome",
        "home",
        "hole",
        "pole",
        "mole",
        "mode",
        "mode"
    };

    [HideInInspector] public string[] silentE9 = new string[]
    {
        "rice",
        "nice",
        "ice",
        "ace",
        "race",
        "rake",
        "take",
        "tale",
        "sale",
        "kale"
    };

    [HideInInspector] public string[] silentE10 = new string[]
    {
        "cage",
        "age",
        "page",
        "pace",
        "place",
        "lace",
        "lake",
        "fake",
        "face",
        "fact"
    };
}
