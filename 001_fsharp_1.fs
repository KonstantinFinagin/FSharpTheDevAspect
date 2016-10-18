let prefix prefixStr baseStr =
    prefixStr + ", " + baseStr

let names = ["David"; "Maria"; "Alex"]

let prefixWithHello = prefix "Hello"

let exclaim s =
    s + "!"

let bigHello = prefixWithHello >> exclaim

names
|> Seq.map prefixWithHello
|> Seq.map exclaim
|> Seq.sort