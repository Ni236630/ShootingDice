using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> SmackTalks { get; } = new List<string>(){
            "What's the matter, you got no power?", 
            "Face it, you'll always just be second best", 
            "I bet your parents were always disappointed in you.",
            "I'm rubber you're glue, whatever you say bounces off of me and sticks to you", 
            "After this i'm going to spend my winnings and take your mom out to dinner."
        };
        
        public void Smack(){
            int listSize = SmackTalks.Count;
            int RndNum =  new Random().Next(listSize); 
          Console.WriteLine(SmackTalks[RndNum]);
        }
        public override void Play(Player other)
        {
            Smack();
            base.Play(other);
        }
    }
}