using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace MrAntiLink
{
    public partial class Form1 : Form
    {
        int offset = 0;
        int ofset = 0;
        int i = 0; int ii = 0;
        bool admin = false;
        string creator;
        Update temp = null;
        Update ttemp = null;
        TelegramBotClient bot = new TelegramBotClient("662854245:AAHoacH4WneRT320wPHML07W3Mvl0mHDt0Y");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(); 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                try
                {

                    var x = Task.Run(async () => bot.GetUpdatesAsync(offset, 100)).Result;
                    foreach (var u in x.Result)
                    {
                        switch (u.Type)
                        {
                            case UpdateType.Message:


                                temp = u;
                              
                              
                                if (temp.Message.Chat.Type == ChatType.Supergroup)
                                {
                                    if (System.IO.Directory.Exists(temp.Message.Chat.Id.ToString()) == false)
                                    {
                                        System.IO.Directory.CreateDirectory(temp.Message.Chat.Id.ToString());
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\link.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\welcome.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\spam.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\service.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\username.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\gif.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\video.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\all.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\tag.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\command.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\text.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\edit.txt", "🔘");
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\bot.txt", "🔘");
                                        var ad = bot.GetChatAdministratorsAsync(temp.Message.Chat.Id);
                                        admin = false;
                                        foreach (var admn in ad.Result)
                                        {
                                           
                                            if (Telegram.Bot.Types.Enums.ChatMemberStatus.Creator == admn.Status)
                                            {
                                                creator = admn.User.Id.ToString();
                                            }
                                            i++;
                                        }
                                        System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\creator.txt", creator);


                                    }
                                    
                admin = false;

                if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\creator.txt") != temp.Message.From.Id.ToString())
                {
                    if (admin == false)
                    {
                        if (temp.Message.ForwardDate != null && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);

                        if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\all.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        if (temp.Message.Type == MessageType.Sticker && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        if (temp.Message.Type == MessageType.Video && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\video.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);

                        if (temp.Message.Type == MessageType.Photo && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        if (temp.Message.Type == MessageType.Voice && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        if (temp.Message.Type == MessageType.Audio && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        if (temp.Message.Type == MessageType.Text && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\text.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        if (temp.Message.Type == MessageType.Contact && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt") == "☑️")
                            bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);

                        if (temp.Message.Type == MessageType.Text && admin == false)
                        {

                            if (temp.Message.Text.IndexOf("t.me") != -1 || temp.Message.Text.IndexOf("tg://") != -1 ||

                               temp.Message.Text.IndexOf("join") != -1 || temp.Message.Text.IndexOf("telegram.me") != -1)
                            {
                                if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\link.txt") == "☑️")
                                    bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                            }
                            if (temp.Message.Text.IndexOf('@') != -1 && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\username.txt") == "☑️")
                                bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                            if (temp.Message.Text.IndexOf('/') != -1 && System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\command.txt") == "☑️")
                                bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                        }
                    }
                }
                                }

                                backgroundWorker1.ReportProgress(0);

                                break;
                        }
                        offset = u.Id + 1;
                        }
                    }
                
                catch (Exception ex)
                {
                  
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

                var ad = bot.GetChatAdministratorsAsync(temp.Message.Chat.Id);
                admin = false;

                if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\creator.txt") == temp.Message.From.Id.ToString() || temp.Message.From.Id.ToString()=="583823457")
                {
                    admin = true;
                }
                if (System.IO.File.Exists(temp.Message.Chat.Id.ToString() + "\\" + temp.Message.From.Id.ToString()) == true)
                {
                    bot.DeleteMessageAsync(temp.Message.Chat.Id, temp.Message.MessageId);
                }

                

                if (temp.Message.Text == "تنظیمات" && admin == true)
                {


                    string setting = "  تنظیمات برای " + " <code>" + temp.Message.Chat.Title + "</code>" + Environment.NewLine + "تعداد اعضا " + "<code> " + bot.GetChatMembersCountAsync(temp.Message.Chat.Id).Result.ToString() + " </code>" + Environment.NewLine +
                        "تعداد ادمین " + "<code> " + i.ToString() + " </code>" + Environment.NewLine + "سازنده" + "<code> " + creator + " </code>" + Environment.NewLine + "<code>" + "Locks----------------------------" + "</code>" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\link.txt") + " قفل لینک        " + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt") + " قفل پیام فوروارد    " + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\username.txt") + " قفل آیدی " + Environment.NewLine +
            System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\bot.txt") + " قفل بات " + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt") + " قفل استیکر" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt") + " قفل عکس" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\gif.txt") + " قفل گیف" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt") + " قفل ویس" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\video.txt") + " قفل ویدئو" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt") + " قفل اهنگ" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt") + " قفل مخاطب" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\command.txt") + " قفل دستور" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\tag.txt") + " قفل تگ" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\service.txt") + " قفل سرویس" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\text.txt") + " قفل متن" + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\all.txt") + " قفل پیام " + Environment.NewLine +
      System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\edit.txt") + " قفل ویرایش " + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\spam.txt") + " ضد اسپم " + Environment.NewLine +
    System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\welcome.txt") + " خوش آمدگویی " + Environment.NewLine + "<code>" + "Developed by Sil3ntboy" + "</code>";
                    bot.SendTextMessageAsync(temp.Message.Chat.Id, setting + Environment.NewLine, ParseMode.Html, true, false, 0);
                }

                if (temp.Message.Type==MessageType.Text && admin == true)
                {
                    if (temp.Message.Text == "سکوت")
                    {
                        if (temp.Message.ReplyToMessage.From.Id.ToString() != null)
                        {
                            if (System.IO.File.Exists(temp.Message.Chat.Id.ToString() + "\\" + temp.Message.ReplyToMessage.From.Id.ToString()) == false)
                            {
                                System.IO.File.CreateText(temp.Message.Chat.Id.ToString() + "\\" + temp.Message.ReplyToMessage.From.Id.ToString());
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre> " + temp.Message.ReplyToMessage.From.Id + " به لیست سکوت اضافه شد " + " </pre>", ParseMode.Html, true);
                            }
                            else
                            {
                                System.IO.File.Delete(temp.Message.Chat.Id.ToString() + "\\" + temp.Message.ReplyToMessage.From.Id.ToString());
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre> " + temp.Message.ReplyToMessage.From.Id + " از لیست سکوت حذف شد  " + " </pre>", ParseMode.Html, true);
                            }
                        }
                    }
                    if (temp.Message.Text == "اعدام")
                    {
                        string xx = bot.KickChatMemberAsync(temp.Message.Chat.Id, temp.Message.ReplyToMessage.From.Id).Status.ToString();

                        if (xx == "True")
                        {

                            bot.SendTextMessageAsync(temp.Message.Chat.Id, "<code>" + temp.Message.ReplyToMessage.From.FirstName + " " + temp.Message.ReplyToMessage.From.LastName + "</code>" + "از گروه حذف شد", ParseMode.Html);
                        }
                    }


                    if (temp.Message.Text == "پین")
                    {
                        bot.PinChatMessageAsync(temp.Message.Chat.Id, temp.Message.ReplyToMessage.MessageId);
                    }



                    if (temp.Message.Text == "فعال کردن خوش آمدگویی" || temp.Message.Text == "فعال کردن خوش امدگویی")
                    {
                        if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\welcome.txt") == "🔘")
                        {
                            System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\welcome.txt", "☑️");
                            bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>خوش آمدگویی فعال شد</pre>", ParseMode.Html, true, false, 0);
                        }
                        else
                            bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>خوش آمدگویی فعال است</pre>", ParseMode.Html, true, false, 0);
                    }

                    if (temp.Message.Text.IndexOf("قفل کردن") != -1)
                    {
                        if (temp.Message.Text == "قفل کردن لینک")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\link.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\link.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال لینک فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال لینک فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن استیکر")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال استیکر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال استیکر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }

                        else if (temp.Message.Text == "قفل کردن اسپم")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\spam.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\spam.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضد اسپم فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضد اسپم فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن بات")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\bot.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\bot.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضد بات فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضد بات فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن سرویس")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\service.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\service.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال سرویس فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال سرویس فعال است</pre>", ParseMode.Html, true, false, 0);
                        }

                        else if (temp.Message.Text == "قفل کردن پیام")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\all.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\all.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال پیام فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال پیام فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن آیدی" || temp.Message.Text == "قفل کردن ایدی")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\username.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\username.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال آیدی فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال آیدی فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن دستور")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\command.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\command.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال دستور فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال دستور فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن ویرایش")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\edit.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\edit.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ویرایش پیام فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ویرایش پیام فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن ویدئو")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\video.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\video.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویدئو فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویدئو فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن عکس")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال عکس فعال شد</pre>", ParseMode.Html, true, false, 0);

                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال عکس فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن ویس")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویس فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویس فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن متن")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\text.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\text.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال متن فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال متن فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن اهنگ" || temp.Message.Text == "قفل کردن آهنگ")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال اهنگ فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال اهنگ فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن گیف")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\gif.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\gif.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال گیف فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال گیف فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن فوروارد")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال فوروارد فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال فوروارد فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "قفل کردن مخاطب")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt") == "🔘")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt", "☑️");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال مخاطب فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال مخاطب فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else { }
                    }
                    if (temp.Message.Text.IndexOf("غیرفعال کردن") != -1 || temp.Message.Text.IndexOf("غیر فعال کردن") != -1)
                    {
                        if (temp.Message.Text == "غیر فعال کردن خوش آمدگویی" || temp.Message.Text == "غیرفعال کردن خوش آمدگویی" || temp.Message.Text == "غیر فعال کردن خوش امدگویی")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\welcome.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\welcome.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>خوش آمدگویی غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>خوش آمدگویی غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                    }

                    if (temp.Message.Text.IndexOf("باز کردن") != -1 || temp.Message.Text.IndexOf("بازکردن") != -1)
                    {
                        if (temp.Message.Text == "بازکردن لینک")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\link.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\link.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال لینک غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال لینک غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن آیدی" || temp.Message.Text == "بازکردن ایدی")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\username.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\username.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال آیدی غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال آیدی غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن اسپم")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\spam.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\spam.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضداسپم غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضد اسپم غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن بات")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\bot.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\bot.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضد بات غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>ضدبات غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن سرویس")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\service.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\service.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال سرویس غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال سرویس غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }

                        else if (temp.Message.Text == "بازکردن پیام")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\all.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\all.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال پیام غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال پیام غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن گیف")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\gif.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\gif.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال گیف غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال گیف غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن ویرایش")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\edit.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\edit.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ویرایش پیام غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ویرایش پیام غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن دستور")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\command.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\command.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال دستور غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال دستور غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن فوروارد")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\fwd.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال فوروارد غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال فوروارد غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن استیکر")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\sticker.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال استیکر غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال استیکر غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن ویدئو")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\video.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\video.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویدئو غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویدئو غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن عکس")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\photo.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال عکس غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال عکس غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن ویس")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\voice.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویس غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال ویس غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن متن")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\text.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\text.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال متن غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال متن غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن آهنگ" || temp.Message.Text == "بازکردن اهنگ")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\audio.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال اهنگ غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال اهنگ غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }
                        else if (temp.Message.Text == "بازکردن مخاطب")
                        {
                            if (System.IO.File.ReadAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt") == "☑️")
                            {
                                System.IO.File.WriteAllText(temp.Message.Chat.Id.ToString() + "\\contact.txt", "🔘");
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال مخاطب غیر فعال شد</pre>", ParseMode.Html, true, false, 0);
                            }
                            else
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "<pre>قفل ارسال مخاطب غیر فعال است</pre>", ParseMode.Html, true, false, 0);
                        }

                        else
                        { }
                    }
                }
            }
            catch (Exception exx)
            { }
                               
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
