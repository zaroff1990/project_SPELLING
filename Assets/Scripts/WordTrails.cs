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
    public string[] cvc2 = new string[]
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

    [HideInInspector]
    public string[] cvc3 = new string[]
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

    [HideInInspector]
    public string[] cvc4 = new string[]
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

    [HideInInspector]
    public string[] cvc5 = new string[]
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

    [HideInInspector]
    public string[] cvc6 = new string[]
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

    [HideInInspector]
    public string[] cvc7 = new string[]
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

    [HideInInspector]
    public string[] cvc8 = new string[]
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

    [HideInInspector]
    public string[] cvc9 = new string[]
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

    [HideInInspector]
    public string[] cvc10 = new string[]
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

    [HideInInspector]
    public string[] digraph1 = new string[]
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

    [HideInInspector]
    public string[] digraph2 = new string[]
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

    [HideInInspector]
    public string[] digraph3 = new string[]
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
    "tip",
    };

    [HideInInspector]
    public string[] digraph4 = new string[]
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
    "Sam",
    };

    [HideInInspector]
    public string[] digraph5 = new string[]
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
    "sack",
    };

    [HideInInspector]
    public string[] digraph6 = new string[]
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
    "rich",
    };

    [HideInInspector]
    public string[] digraph7 = new string[]
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
    "rash",
    };

    [HideInInspector]
    public string[] digraph8 = new string[]
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
    "shin",
    };

    [HideInInspector]
    public string[] digraph9 = new string[]
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
    "rush",
    };

    [HideInInspector]
    public string[] digraph10 = new string[]
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
    "win",
    };

    [HideInInspector]
    public string[] floss1 = new string[]
    {
    "sap",
    "sack",
    "sick",
    "thick",
    "Nick",
    "lick",
    "Mick",
    "mit",
    "mill",
    "fill",
    };

    [HideInInspector]
    public string[] floss2 = new string[]
    {
    "then",
    "when",
    "Ken",
    "men",
    "mess",
    "mesh",
    "mash",
    "mass",
    "pass",
    "path",
    };

    [HideInInspector]
    public string[] floss3 = new string[]
    {
    "dot",
    "dog",
    "jog",
    "jug",
    "chug",
    "thug",
    "lug",
    "rug",
    "run",
    "ruff",
    };

    [HideInInspector]
    public string[] floss4 = new string[]
    {
    "duck",
    "chuck",
    "tuck",
    "yuck",
    "shuck",
    "luck",
    "lush",
    "lull",
    "gull",
    "dull",
    };

    [HideInInspector]
    public string[] floss5 = new string[]
    {
    "kiss",
    "miss",
    "mess",
    "less",
    "let",
    "pet",
    "pit",
    "pill",
    "fill",
    "fell",
    };

    [HideInInspector]
    public string[] floss6 = new string[]
    {
    "tin",
    "fin",
    "fill",
    "fizz",
    "fuzz",
    "buzz",
    "bun",
    "buff",
    "puff",
    "cuff",
    };

    [HideInInspector]
    public string[] floss7 = new string[]
    {
    "huff",
    "puff",
    "pug",
    "peg",
    "pig",
    "pill",
    "sill",
    "sell",
    "bell",
    "bill",
    };

    [HideInInspector]
    public string[] floss8 = new string[]
    {
    "hill",
    "hall",
    "fall",
    "fell",
    "tell",
    "till",
    "tip",
    "rip",
    "riff",
    "ruff",
    };

    [HideInInspector]
    public string[] floss9 = new string[]
    {
    "toss",
    "loss",
    "less",
    "mess",
    "miss",
    "mill",
    "mall",
    "call",
    "fall",
    "fell",
    };

    [HideInInspector]
    public string[] floss10 = new string[]
    {
    "fizz",
    "fuzz",
    "buzz",
    "buff",
    "puff",
    "pug",
    "peg",
    "pig",
    "pill",
    "will",
    };

    [HideInInspector]
    public string[] iConsonate1 = new string[]
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
    "mess",
    };

    [HideInInspector]
    public string[] iConsonate2 = new string[]
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
    "clog",
    };

    [HideInInspector]
    public string[] iConsonate3 = new string[]
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
    "stag",
    };

    [HideInInspector]
    public string[] iConsonate4 = new string[]
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
    "slum",
    };

    [HideInInspector]
    public string[] iConsonate5 = new string[]
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
    "dell",
    };

    [HideInInspector]
    public string[] iConsonate6 = new string[]
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
    "sock",
    };

    [HideInInspector]
    public string[] iConsonate7 = new string[]
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
    "brass",
    };

    [HideInInspector]
    public string[] iConsonate8 = new string[]
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
    "grab",
    };

    [HideInInspector]
    public string[] iConsonate9 = new string[]
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
    "him",
    };

    [HideInInspector]
    public string[] iConsonate10 = new string[]
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
    "slid",
    };

    [HideInInspector]
    public string[] fConsonate1 = new string[]
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
    "cast",
    };

    [HideInInspector]
    public string[] fConsonate2 = new string[]
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
    "bent",
    };

    [HideInInspector]
    public string[] fConsonate3 = new string[]
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
    "bin",
    };

    [HideInInspector]
    public string[] fConsonate4 = new string[]
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
    "kept",
    };

    [HideInInspector]
    public string[] fConsonate5 = new string[]
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
    "silk",
    };

    [HideInInspector]
    public string[] fConsonate6 = new string[]
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
    "left",
    };

    [HideInInspector]
    public string[] fConsonate7 = new string[]
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
    "hint",
    };

    [HideInInspector]
    public string[] fConsonate8 = new string[]
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
    "kelp",
    };

    [HideInInspector]
    public string[] fConsonate9 = new string[]
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
    "felt",
    };

    [HideInInspector]
    public string[] fConsonate10 = new string[]
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
    "cast",
    };

    [HideInInspector]
    public string[] bConsonate1 = new string[]
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
    "tract",
    };

    [HideInInspector]
    public string[] bConsonate2 = new string[]
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
    "shrink",
    };

    [HideInInspector]
    public string[] bConsonate3 = new string[]
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
    "frank",
    };

    [HideInInspector]
    public string[] bConsonate4 = new string[]
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
    "strong",
    };

    [HideInInspector]
    public string[] bConsonate5 = new string[]
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
    "hung",
    };

    [HideInInspector]
    public string[] bConsonate6 = new string[]
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
    "class",
    };

    [HideInInspector]
    public string[] bConsonate7 = new string[]
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
    "sand",
    };

    [HideInInspector]
    public string[] bConsonate8 = new string[]
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
    "crock",
    };

    [HideInInspector]
    public string[] bConsonate9 = new string[]
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
    "rack",
    };

    [HideInInspector]
    public string[] bConsonate10 = new string[]
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
    "pend",
    };

    [HideInInspector]
    public string[] syllables1 = new string[]
    {
    "shed",
    "she",
    "be",
    "bed",
    "bid",
    "hid",
    "hi",
    "him",
    "hit",
    "sit",
    };

    [HideInInspector]
    public string[] syllables2 = new string[]
    {
    "got",
    "go",
    "gosh",
    "nosh",
    "no",
    "not",
    "pot",
    "pet",
    "wet",
    "we",
    };

    [HideInInspector]
    public string[] syllables3 = new string[]
    {
    "hi",
    "hit",
    "him",
    "dim",
    "him",
    "hem",
    "hi",
    "hid",
    "had",
    "pad",
    };

    [HideInInspector]
    public string[] syllables4 = new string[]
    {
    "she",
    "shed",
    "bed",
    "be",
    "bet",
    "met",
    "me",
    "men",
    "hen",
    "he",
    };

    [HideInInspector]
    public string[] syllables5 = new string[]
    {
    "so",
    "sob",
    "gob",
    "go",
    "get",
    "wet",
    "we",
    "wed",
    "bed",
    "be",
    };

    [HideInInspector]
    public string[] syllables6 = new string[]
    {
    "not",
    "no",
    "nod",
    "bod",
    "bed",
    "be",
    "she",
    "shed",
    "red",
    "led",
    };

    [HideInInspector]
    public string[] syllables7 = new string[]
    {
    "met",
    "me",
    "we",
    "wet",
    "get",
    "net",
    "not",
    "no",
    "go",
    "got",
    };

    [HideInInspector]
    public string[] syllables8 = new string[]
    {
    "got",
    "go",
    "gob",
    "sob",
    "so",
    "no",
    "nod",
    "god",
    "go",
    "yo",
    };

    [HideInInspector]
    public string[] syllables9 = new string[]
    {
    "met",
    "me",
    "men",
    "hen",
    "he",
    "be",
    "bet",
    "bit",
    "hit",
    "hi",
    };

    [HideInInspector]
    public string[] syllables10 = new string[]
    {
    "be",
    "by",
    "shy",
    "she",
    "shed",
    "bed",
    "be",
    "by",
    "why",
    "my",
    };

    [HideInInspector]
    public string[] silent1 = new string[]
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
    "site",
    };

    [HideInInspector]
    public string[] silent2 = new string[]
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
    "biz",
    };

    [HideInInspector]
    public string[] silent3 = new string[]
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
    "pill",
    };

    [HideInInspector]
    public string[] silent4 = new string[]
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
    "fill",
    };

    [HideInInspector]
    public string[] silent5 = new string[]
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
    "find",
    };

    [HideInInspector]
    public string[] silent6 = new string[]
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
    "same",
    };

    [HideInInspector]
    public string[] silent7 = new string[]
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
    "pal",
    };

    [HideInInspector]
    public string[] silent8 = new string[]
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
    "mode", // You have 'mode' twice, is this intentional?
    };

    [HideInInspector]
    public string[] silent9 = new string[]
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
    "kale",
    };

    [HideInInspector]
    public string[] silent10 = new string[]
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
    "fact",
    };

    [HideInInspector]
    public string[] bossy1 = new string[]
    {
    "car",
    "cart",
    "cat",
    "mat",
    "mart",
    "tart",
    "start",
    "star",
    "stir",
    "sir",
    };

    [HideInInspector]
    public string[] bossy2 = new string[]
    {
    "yurt",
    "curt",
    "curl",
    "curb",
    "carb",
    "car",
    "far",
    "farm",
    "harm",
    "hard",
    };

    [HideInInspector]
    public string[] bossy3 = new string[]
    {
    "mark",
    "park",
    "lark",
    "lurk",
    "lurch",
    "church",
    "churn",
    "turn",
    "turf",
    "surf",
    };

    [HideInInspector]
    public string[] bossy4 = new string[]
    {
    "burp",
    "burn",
    "barn",
    "bar",
    "bark",
    "park",
    "par",
    "far",
    "farm",
    "harm",
    };

    [HideInInspector]
    public string[] bossy5 = new string[]
    {
    "thorn",
    "born",
    "barn",
    "bar",
    "ban",
    "band",
    "hand",
    "hard",
    "card",
    "carb",
    };

    [HideInInspector]
    public string[] bossy6 = new string[]
    {
    "third",
    "bird",
    "bid",
    "lid",
    "lad",
    "lard",
    "hard",
    "herd",
    "her",
    "he",
    };

    [HideInInspector]
    public string[] bossy7 = new string[]
    {
    "car",
    "far",
    "for",
    "form",
    "norm",
    "nor",
    "for",
    "fork",
    "cork",
    "corn",
    };

    [HideInInspector]
    public string[] bossy8 = new string[]
    {
    "surf",
    "turf",
    "turn",
    "burn",
    "born",
    "corn",
    "cork",
    "pork",
    "port",
    "sort",
    };

    [HideInInspector]
    public string[] bossy9 = new string[]
    {
    "barn",
    "bark",
    "park",
    "part",
    "port",
    "fort",
    "for",
    "fork",
    "cork",
    "cord",
    };

    [HideInInspector]
    public string[] bossy10 = new string[]
    {
    "mark",
    "mart",
    "tart",
    "start",
    "star",
    "tar",
    "tarp",
    "harp",
    "harm",
    "farm",
    };

    [HideInInspector]
    public string[] long1 = new string[]
    {
    "bee",
    "see",
    "seen",
    "seed",
    "need",
    "feed",
    "feet",
    "sheet",
    "beet",
    "beat",
    };

    [HideInInspector]
    public string[] long2 = new string[]
    {
    "sea",
    "tea",
    "team",
    "steam",
    "seam",
    "seat",
    "heat",
    "beat",
    "beam",
    "bead",
    };

    [HideInInspector]
    public string[] long3 = new string[]
    {
    "maid",
    "paid",
    "pain",
    "rain",
    "raid",
    "rail",
    "sail",
    "pail",
    "mail",
    "main",
    };

    [HideInInspector]
    public string[] long4 = new string[]
    {
    "day",
    "hay",
    "say",
    "sway",
    "stay",
    "say",
    "pay",
    "lay",
    "play",
    "clay",
    };

    [HideInInspector]
    public string[] long5 = new string[]
    {
    "high",
    "sigh",
    "sight",
    "fight",
    "flight",
    "light",
    "might",
    "night",
    "right",
    "tight",
    };

    [HideInInspector]
    public string[] long6 = new string[]
    {
    "boat",
    "oat",
    "coat",
    "coast",
    "boast",
    "boat",
    "goat",
    "goal",
    "coal",
    "coat",
    };

    [HideInInspector]
    public string[] long7 = new string[]
    {
    "toe",
    "tow",
    "bow",
    "low",
    "slow",
    "sow",
    "bow",
    "row",
    "show",
    "shown",
    };

    [HideInInspector]
    public string[] long8 = new string[]
    {
    "soon",
    "moon",
    "mood",
    "food",
    "fool",
    "pool",
    "tool",
    "stool",
    "steel",
    "steep",
    };

    [HideInInspector]
    public string[] long9 = new string[]
    {
    "soon",
    "spoon",
    "spook",
    "spool",
    "pool",
    "tool",
    "tail",
    "nail",
    "snail",
    "sail",
    };

    [HideInInspector]
    public string[] long10 = new string[]
    {
    "drew",
    "dew",
    "few",
    "flew",
    "blew",
    "blue",
    "clue",
    "clay",
    "play",
    "pay",
    };

    [HideInInspector]
    public string[] tricky1 = new string[]
    {
    "shoot",
    "shout",
    "out",
    "pout",
    "tout",
    "lout",
    "gout",
    "grout",
    "trout",
    "treat",
    };

    [HideInInspector]
    public string[] tricky2 = new string[]
    {
    "shook",
    "cook",
    "nook",
    "look",
    "rook",
    "crook",
    "brook",
    "book",
    "beek",
    "seek",
    };

    [HideInInspector]
    public string[] tricky3 = new string[]
    {
    "point",
    "join",
    "join",
    "coin",
    "coil",
    "oil",
    "foil",
    "fool",
    "fuel",
    "duel",
    };

    [HideInInspector]
    public string[] tricky4 = new string[]
    {
    "town",
    "gown",
    "down",
    "drown",
    "frown",
    "crown",
    "clown",
    "crown",
    "crow",
    "grow",
    };

    [HideInInspector]
    public string[] tricky5 = new string[]
    {
    "round",
    "bound",
    "mound",
    "found",
    "sound",
    "round",
    "hound",
    "wound",
    "pound",
    "pond",
    };

    [HideInInspector]
    public string[] tricky6 = new string[]
    {
    "boy",
    "joy",
    "soy",
    "toy",
    "tee",
    "teeth",
    "tooth",
    "booth",
    "book",
    "took",
    };

    [HideInInspector]
    public string[] tricky7 = new string[]
    {
    "claw",
    "law",
    "slaw",
    "saw",
    "jaw",
    "paw",
    "pawn",
    "lawn",
    "law",
    "flaw",
    };

    [HideInInspector]
    public string[] tricky8 = new string[]
    {
    "hood",
    "head",
    "bead",
    "bread",
    "read",
    "real",
    "rail",
    "trail",
    "tail",
    "tool",
    };

    [HideInInspector]
    public string[] tricky9 = new string[]
    {
    "seal",
    "steal",
    "teal",
    "veal",
    "veil",
    "vein",
    "rein",
    "rain",
    "grain",
    "groan",
    };

    [HideInInspector]
    public string[] tricky10 = new string[]
    {
    "mouth",
    "south",
    "sour",
    "our",
    "out",
    "bout",
    "boot",
    "foot",
    "food",
    "good",
    };

}
