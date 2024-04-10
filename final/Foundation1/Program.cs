using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // https://www.youtube.com/watch?v=lj9U5Yb2MXQ
        Video video1 = new Video("Max Damage Loadouts in Terraria", "Gungir", 1551);
        Comment video1Comment1 = new Comment("toomuchdog74", "I like how the Mage in Endgame isn’t even referred to as “Mage”, it has basically turned to “The Last Prism set”");
        Comment video1Comment2 = new Comment("mochii2229", "Melee class: almost dead last in dps                 Zenith: hold my beer");
        Comment video1Comment3 = new Comment("ironicweeb6684", "Summoner: For those who prioritize assistance rather than attacking Mage: For those who love seeing the boss health bar sink Ranger: For those who loves the feeling of satisfaction with guaranteed crits. Melee: For the brainless who want to deal a lot of damage (Me)");
        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);
        videosList.Add(video1);

        // https://www.youtube.com/watch?v=iJC__go30_8
        Video video2 = new Video("Bob’s Burgers Scenes That I Quote Daily", "devilh0rns", 305);
        Comment video2Comment1 = new Comment("juneBug412", "it's sweet that bob laughed at linda's reason for slippin viagra into his food, the way they casually joke around with their intimacy really sells em as legitimately happily married n i adore it");
        Comment video2Comment2 = new Comment("Aj-cs6cw", "IIIIIIII… wish my radio worked! Always gets me");
        Comment video2Comment3 = new Comment("JJCHAU", "Teddy being legitimately scared of the cake hand slapping always gets me ");
        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);
        videosList.Add(video2);

        // https://www.youtube.com/watch?v=Byd_Mdajqo0
        Video video3 = new Video("Primitive Technology: Crab and Fish Trap", "Primitive Technology", 636);
        Comment video3Comment1 = new Comment("izzyplusplusplus1004", "The OG wilderness survival channel that sparked an entire genre of content. Still the best. Well done sir.");
        Comment video3Comment2 = new Comment("matthew3103", "For those interested the fish are purple spotted gudgeons (Mogurnda adspersa/mogurnda: likely adspersa as they have the latgest range distribution), the prawns are most likely East Australian river prawns (Macrobrachium tolmerum), the crab is a river swimming crab (Varuna litterata). Oh and the eels are longfin eels");
        Comment video3Comment3 = new Comment("ladimoradeivideogiochi2858", "Friendly reminder that by putting on subtitles you get a lovely explaination of everything that's going on");
        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);
        videosList.Add(video3);
        
        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}