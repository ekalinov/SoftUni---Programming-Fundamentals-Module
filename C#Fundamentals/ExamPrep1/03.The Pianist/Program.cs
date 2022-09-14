using System;
using System.Collections.Generic;

namespace _03.The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> collection = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] pieceArgs = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string pieceKey = pieceArgs[0];
                string composerKeyValue = $"{pieceArgs[1]}|{pieceArgs[2]}";

                collection.Add(pieceKey, composerKeyValue);

            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commandArg = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArg[0];

                if (action== "Add")
                {
                    //•	"Add|{piece}|{composer}|{key}":
                    //o You need to add the given piece with the information about it to the other pieces and print:
                    //                "{piece} by {composer} in {key} added to the collection!"
                    //o If the piece is already in the collection, print:
                    //"{piece} is already in the collection!"
                    string piece = commandArg[1];
                    string composerKeyValue = $"{commandArg[2]}|{commandArg[3]}";
                   
                    if (collection.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                        continue;
                    }
                    else
                    {
                        collection.Add(piece, composerKeyValue);
                        Console.WriteLine($"{piece} by {commandArg[2]} in {commandArg[3]} added to the collection!"); 
                    }

                }
                else if (action == "Remove")
                {
                    //•	"Remove|{piece}":
                    //o If the piece is in the collection, remove it and print:
                    //                "Successfully removed {piece}!"
                    //o Otherwise, print:
                    //"Invalid operation! {piece} does not exist in the collection."

                    string piece = commandArg[1];
                    if (collection.ContainsKey(piece))
                    {
                        collection.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }


                }
                else if (action == "ChangeKey")
                {
                    //•	"ChangeKey|{piece}|{new key}":
                    //o If the piece is in the collection, change its key with the given one and print:
                    //"Changed the key of {piece} to {new key}!"
                    //o Otherwise, print:
                    //"Invalid operation! {piece} does not exist in the collection."
                    string piece = commandArg[1];
                    string newKey = commandArg[2];
                    

                    if (collection.ContainsKey(piece))
                    {
                        string[] oldComposerKeyValue = collection[piece].Split("|",StringSplitOptions.RemoveEmptyEntries);
                        string composer = oldComposerKeyValue[0];
                        string oldKeyValue = oldComposerKeyValue[1];

                        string newComposerKeyValue = $"{composer}|{newKey}";

                        collection[piece] = newComposerKeyValue;

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }

            }

            foreach (var piece in collection)
            {
                string pieceName = piece.Key;
                string[] composerKey = piece.Value.Split("|",StringSplitOptions.RemoveEmptyEntries);

                string composer = composerKey[0];
                string key = composerKey[1];

                Console.WriteLine($"{pieceName} -> Composer: {composer}, Key: {key}");

            }
            //Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:
            //                "{Piece} -> Composer: {composer}, Key: {key}"







        }
    }
}
