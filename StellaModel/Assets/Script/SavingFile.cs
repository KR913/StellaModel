using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SavingFile
{
    public string H1 = "The Greeks linked Aquarius with Ganymede, the cup bearer to the gods. According to lore, Ganymede was a good-looking young man who was the object of Zeus' affection and was brought to Mount Olympus, where he served as cup bearer to the gods and was granted eternal youth.";
    public string H2 = "The Greeks and traditionally associated the Aries constellation with a ram. In Greek mythology, the ram was sacrificed to Zeus, the Greek leader of the gods. Its golden fleece later led to the journey of Jason and the Argonaunt, one of the greatest journeys in Greek mythology.";
    public string H3 = "The constellation of Cancer represents the giant crab Karkinos that attacked Hercules during the second of the 12 labors he performed as penance for killing his family. It was sent by the jealous goddess Hera to thwart Hercules as he battled the water serpent Hydra, but he killed it.";
    public string H4 = "The Greeks associate the constellation of Capricorn with Pan, the god of wild and nature. The god had a horrible shout that could frighten even the Titans. In the Battle of Marathon, Pan was said to have inspired panic in the hearts of the Persians. The word [Panic] derives from his name.";
    public string H5 = "The Gemini is identified as twin half-brothers Pollux and Castor known together as Dioscuri (Sons of Zeus). While Pollux was a divine son of Zeus, Castor is a mortal. Their bond was strong enough to move the heart of the chief god who helped them stay together even after the death of Castor.";
    public string H6 = "In Greek mythology, Leo is the Nemean Lion, which terrorized the citizens. It had claws sharper than any mortal weapons and a hide that could not punctured by iron, bronze or stone. Killing the lion was one of Hercules' 12 labors, which he had to perform as penance for killing his family.";
    public string H7 = "While the ancient Greeks viewed Libra as the claws of Scorpio reaching out, the constellation can also be viewed as the scale that represents justice, balance and harmony. The scale belonged to Dike, the goddess of justice, the spirit of moral order and fair judgment and the embodiment of Virgo.";
    public string H8 = "In the sky, Pisces is represented as two fish attached by a cord. The fish are apparently the Greek goddess Aphrodite and her son, Eros, who turned into fish and jumped into the Euphrates River to evade the fiery breath of the monster Typhon, the most awful monster the world had ever seen.";
    public string H9 = "The Greeks identify Sagittarius as a centaur, horse-human hybrid with the body of a man atop the four legs of a horse. The creature is aiming an arrow toward its neighbor Scorpio. The lore has Sagittarius the Archer shooting Scorpio the Scorpion, which had been sent to kill Orion the Hunter.";
    public string H10 = "Scorpio represents the scorpion sent by the god Apollo, Artemis's twin brother to kill Orion the giant hunter. The creature's sting was poisonous enough to kill the giant with one strike. After the battle, Zeus put Orion and Scorpio in the sky, but they are visible at different times of the year.";
    public string H11 = "The ancient Greeks associate Taurus with the chief god Zeus. When Zeus fell in love with the Phoenician Princess Europa, he transformed himself into a white bull with golden horns. As the princess was captured by his beauty and hopped into his back, the bull carried Europa away to Crete.";
    public string H12 = "Virgo is linked with Dike, who somtimes is referred as Astraea, the virgin goddess of justice. The celestial maiden was the last immortal to live with human. While she has left the Earth due to her disappointment in humanity, it was said that one day she will return, along with the utopian golden age.";

    public SavingFile() { }
    public SavingFile(string H1,string H2, string H3, string H4, string H5, string H6, string H7, string H8, string H9, string H10, string H11, string H12)
    {
        this.H1 = H1;
        this.H2 = H2;
        this.H3 = H3;
        this.H4 = H4;
        this.H5 = H5;
        this.H6 = H6;
        this.H7 = H7;
        this.H8 = H8;
        this.H9 = H9;
        this.H10 = H10;
        this.H11 = H11;
        this.H12 = H12;
    }
}
