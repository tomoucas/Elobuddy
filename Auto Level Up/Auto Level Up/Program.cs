using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;

namespace Auto_Level_Up
{
    internal class Program
    {
        public static AIHeroClient User;
        public static Spellbook Abilities;
        public static Menu Menu;
        public static void Main()
        {
            Loading.OnLoadingComplete += Game_OnStart;
        }
        public static void Game_OnStart(EventArgs args)
        {
            Player.OnLevelUp += Player_OnLevelUp;
            User = Player.Instance;
            Abilities = User.Spellbook;
            Menu = MainMenu.AddMenu("Auto Level Up", "Menu");
            Menu.Add("lvl2ability", new ComboBox("Level 2", 0, "Q", "W", "E"));
            Menu.Add("lvl3ability", new ComboBox("Level 3", 0, "Q", "W", "E"));
            Menu.Add("lvl4ability", new ComboBox("Level 4", 0, "Q", "W", "E"));
            Menu.Add("after4", new ComboBox("Ability Priority", 0, "R>Q>W>E", "R>Q>E>W", "R>W>Q>E", "R>W>E>Q", "R>E>Q>W", "R>E>W>Q"));
            Menu.Add("delay", new Slider("Delay (milliseconds)", 0, 10, 1000));
        }
        public static void Player_OnLevelUp(Obj_AI_Base sender, Obj_AI_BaseLevelUpEventArgs args)
        {
            Core.DelayAction(() =>
            {
                if (User.Level < 5)
                {
                    switch (User.Level)
                    {
                        case 1:
                            switch (Menu["lvl1ability"].Cast<ComboBox>().SelectedText)
                            {
                                case "Q":
                                    Abilities.LevelSpell(SpellSlot.Q);
                                    break;
                                case "W":
                                    Abilities.LevelSpell(SpellSlot.W);
                                    break;
                                case "E":
                                    Abilities.LevelSpell(SpellSlot.E);
                                    break;
                            }
                            break;
                        case 2:
                            switch (Menu["lvl2ability"].Cast<ComboBox>().SelectedText)
                            {
                                case "Q":
                                    Abilities.LevelSpell(SpellSlot.Q);
                                    break;
                                case "W":
                                    Abilities.LevelSpell(SpellSlot.W);
                                    break;
                                case "E":
                                    Abilities.LevelSpell(SpellSlot.E);
                                    break;
                            }
                            break;
                        case 3:
                            switch (Menu["lvl3ability"].Cast<ComboBox>().SelectedText)
                            {
                                case "Q":
                                    Abilities.LevelSpell(SpellSlot.Q);
                                    break;
                                case "W":
                                    Abilities.LevelSpell(SpellSlot.W);
                                    break;
                                case "E":
                                    Abilities.LevelSpell(SpellSlot.E);
                                    break;
                            }
                            break;
                        case 4:
                            switch (Menu["lvl4ability"].Cast<ComboBox>().SelectedText)
                            {
                                case "Q":
                                    Abilities.LevelSpell(SpellSlot.Q);
                                    break;
                                case "W":
                                    Abilities.LevelSpell(SpellSlot.W);
                                    break;
                                case "E":
                                    Abilities.LevelSpell(SpellSlot.E);
                                    break;
                            }
                            break;
                    }
                }
                if (User.Level > 4)
                {
                    switch (Menu["after4"].Cast<ComboBox>().SelectedText)
                    {
                        case "R>Q>W>E":
                            if (Abilities.CanSpellBeUpgraded(SpellSlot.R))
                            {
                                Abilities.LevelSpell(SpellSlot.R);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.Q))
                            {
                                Abilities.LevelSpell(SpellSlot.Q);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.W))
                            {
                                Abilities.LevelSpell(SpellSlot.W);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.E))
                            {
                                Abilities.LevelSpell(SpellSlot.E);
                            }
                            break;
                        case "R>Q>E>W":
                            if (Abilities.CanSpellBeUpgraded(SpellSlot.R))
                            {
                                Abilities.LevelSpell(SpellSlot.R);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.Q))
                            {
                                Abilities.LevelSpell(SpellSlot.Q);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.E))
                            {
                                Abilities.LevelSpell(SpellSlot.E);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.W))
                            {
                                Abilities.LevelSpell(SpellSlot.W);
                            }
                            break;
                        case "R>W>Q>E":
                            if (Abilities.CanSpellBeUpgraded(SpellSlot.R))
                            {
                                Abilities.LevelSpell(SpellSlot.R);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.W))
                            {
                                Abilities.LevelSpell(SpellSlot.W);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.Q))
                            {
                                Abilities.LevelSpell(SpellSlot.Q);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.E))
                            {
                                Abilities.LevelSpell(SpellSlot.E);
                            }
                            break;
                        case "R>W>E>Q":
                            if (Abilities.CanSpellBeUpgraded(SpellSlot.R))
                            {
                                Abilities.LevelSpell(SpellSlot.R);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.W))
                            {
                                Abilities.LevelSpell(SpellSlot.W);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.E))
                            {
                                Abilities.LevelSpell(SpellSlot.E);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.Q))
                            {
                                Abilities.LevelSpell(SpellSlot.Q);
                            }
                            break;
                        case "R>E>Q>W":
                            if (Abilities.CanSpellBeUpgraded(SpellSlot.R))
                            {
                                Abilities.LevelSpell(SpellSlot.R);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.E))
                            {
                                Abilities.LevelSpell(SpellSlot.E);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.Q))
                            {
                                Abilities.LevelSpell(SpellSlot.Q);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.W))
                            {
                                Abilities.LevelSpell(SpellSlot.W);
                            }
                            break;
                        case "R>E>W>Q":
                            if (Abilities.CanSpellBeUpgraded(SpellSlot.R))
                            {
                                Abilities.LevelSpell(SpellSlot.R);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.E))
                            {
                                Abilities.LevelSpell(SpellSlot.E);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.W))
                            {
                                Abilities.LevelSpell(SpellSlot.W);
                            }
                            else if (Abilities.CanSpellBeUpgraded(SpellSlot.Q))
                            {
                                Abilities.LevelSpell(SpellSlot.Q);
                            }
                            break;
                    }
                }
            }, Menu["delay"].Cast<Slider>().CurrentValue);
        }
    }
}
