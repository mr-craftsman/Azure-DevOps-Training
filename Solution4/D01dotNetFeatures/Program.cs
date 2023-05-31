// See https://aka.ms/new-console-template for more information
using C10Constructors;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
//using C10Constructor;

// main differences btw. .net core and .net framework
// 1. Core - cross-platform - linux, mac, mobile, win
// 2. Open source 
// 3. Modularity

// copy weather class form day 3 Solution 3 waether application
// using 'Add projekt recerence' add reference to weather manager library d04 out of other solution
// don`t have to use Console.ReadKey();

// F12 / rmb 'go to definition' to get to a class

// regex dictionary - use www.regex101.com to find and practice regex manipulations

//dwonlowaded with webclient entire html file, then find elements
// elements found by inspecting code with code inspector, with thieir respective 'hashes'
// hashes are regex, use regex to get all matching hashes into one expression
// use Regex class and then Match method

// ! -exclamation mark
// @ - at sign

// # - hash, pound, or octothorpe
// $ - dollar sign
// % - percent sign
// ^ - caret or circumflex
// & - ampersand

// * asterisk or star
// ( - left parenthesis or open parenthesis
// ) -right parenthesis or close parenthesis
// - hyphen or minus
// + plus sign
// = - equals sign
// , - comma
// . - period or dot
// / - forward slash or solidus
// < - less-than sign
// > greater-than sign
// ; -semicolon
// : -colon
// [- left bracket or open bracket
// ] - right bracket or close bracket
// { - left brace or open brace
// } - right brace or close brace
// ` - backtick or grave accent
// ? question mark.

WebClient webClient = new WebClient();

string address = $"https://www.google.com/search?q=weather+";
string city = "London";
string text = webClient.DownloadString(address + city);

string pattern = "<div class=\"BNeawe iBp4i AP7Wnd\">(-{0,1}\\d{1,2}.{0,1}\\d{0,2}).C<\\/div>";

Regex rx = new Regex(pattern);
Match match = rx.Match(text);

string result = match.Groups[1].Value;

Console.WriteLine(result);

File.WriteAllText("output.html", text);

// main differences between .net core and .net framework are 

// 1) cross - platform 
// 2) open-source 
// 3) modularity 


//WeatherManager weatherManager = new WeatherManager();

//double temp=  weatherManager.GetTemperature("warsaw");
//Console.WriteLine(temp);

WebClient webClient = new WebClient();

string address = $"https://www.google.com/search?q=weather+";
string city = "warsaw";
string text = webClient.DownloadString(address + city);

string pattern = "<div class=\"BNeawe iBp4i AP7Wnd\">(-{0,1}\\d{1,2}.{0,1}\\d{0,2}).C<\\/div>";

string someString = "hello\\ntomasz";
Console.WriteLine(someString);

Regex rx = new Regex(pattern);
Match match = rx.Match(text);

string result = match.Groups[1].Value;



// to change :
Console.WriteLine(result);

File.WriteAllText("output.html", text);
//Console.ReadKey();


// dictionary: 

//!-exclamation mark
//@ - at sign

//# - hash, pound, or octothorpe
//$ - dollar sign
//% - percent sign
//^ - caret or circumflex
//& - ampersand

//* asterisk or star
//( - left parenthesis or open parenthesis
//) -right parenthesis or close parenthesis
// - hyphen or minus
// + plus sign
// = - equals sign
// , - comma
// . - period or dot
// / - forward slash or solidus
// < - less-than sign
// > greater-than sign
// ; -semicolon
// : -colon
// [- left bracket or open bracket
// ] - right bracket or close bracket
// { - left brace or open brace
// } - right brace or close brace
// ` - backtick or grave accent
// ? question mark.

