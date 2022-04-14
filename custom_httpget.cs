WebClient wc = new WebClient();//add web functions :o

public void StartWeb()//optional: may increase downloading speed
{
    string wt;
    wt = wc.DownloadString("https://gist.githubusercontent.com/clxyify/d80a5164a09d4e3f03d17d02c46cc4a2/raw/20a98db2221228b95abefb8b1dbfca058f91e297/test");
    //you can replace link with anything you just need to start up the web
}

public void HttpGet(string link)
{
   string script = wc.DownloadString(link);//download the script
   System.Threading.Thread.Sleep(100);//use cooldown
   API.Execute(script);//execute the script with API
   System.Threading.Thread.Sleep(50);//use cooldown
   script = "";//clear the script so we wont execute the same link
   if (script == "") {} else { script == ""; }//force clear again
}
