#pragma checksum "C:\Users\sony\Documents\blazor\sikhgame\Pages\Hangman.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdcab590017cd4f2dbba83e63cbe8a047def27a3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace sikhgame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using sikhgame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sony\Documents\blazor\sikhgame\_Imports.razor"
using sikhgame.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hangman")]
    public partial class Hangman : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\sony\Documents\blazor\sikhgame\Pages\Hangman.razor"
       
    private const string STATUS_TEXT_IN_PLAY = "In play";
    private const string STATUS_TEXT_FINISHED_FAILED = "Finished: Sorry you didn't get it right. The answer is {0}";
    private const string STATUS_TEXT_FINISHED_SUCCESS = "Finished: Congratulations you got it right. The answer is {0}";
    private const string PLACE_HOLDER = "o";
    private const string STATUS_STYLE_IN_PLAY = "warning";
    private const string STATUS_STYLE_FINISHED_FAILED = "danger";
    private const string STATUS_STYLE_FINISHED_SUCCESS = "success";

    private const string HANGMAN_DATA_FILE = "sample-data/hangman.json";

    private HangmanData hangman;

    public GameState gameState;

    public class GameState{
        public Question CurrentQuestion{get;set;}
        public List<Question> AnsweredQuestions{get;set;}
    }

    public class Question
    {
        public string Answer { get; set; }
        public string CurrentAnswer{get;set;}
        public string[] Tags { get; set; }
        public string[] Clues { get; set; }
        public List<string> LettersUsed {get;set;}
        public Status Status{get;set;}
        public int RemainingChances {get;set;} = 13;
    }

    public class Status{

        public string Style{get;set;}
        public string Text{get;set;}
    }

    public class HangmanData
    {
        public List<LetterButton> Consonants { get; set; }
        public List<string> Vowels { get; set; }
        public List<Question> Questions {get;set;}
    }

    public class LetterButton{
        public string Letter {get;set;}
        public string Status {get;set;}
    }

    protected override async Task OnInitializedAsync()
    {
        hangman = await Http.GetFromJsonAsync<HangmanData>(HANGMAN_DATA_FILE);
        gameState = new GameState();

        gameState.AnsweredQuestions = new List<Question>();

        NewQuestion();
    }

    private void NewQuestion(){
        var random = new Random();

        int index = 0;

        // Don't allow the same question twice
        do
        {
            index = random.Next(hangman.Questions.Count);
            gameState.CurrentQuestion = hangman.Questions[index];
            gameState.CurrentQuestion.LettersUsed = new List<string>();
            gameState.CurrentQuestion.CurrentAnswer = gameState.CurrentQuestion.Answer;
            gameState.CurrentQuestion.Status = new Status(){Text=STATUS_TEXT_IN_PLAY, Style=STATUS_STYLE_IN_PLAY};

        } while ( gameState.AnsweredQuestions != null && gameState.AnsweredQuestions.Count < hangman.Questions.Count &&
                gameState.AnsweredQuestions.Where(w => w.Answer == gameState.CurrentQuestion.CurrentAnswer).Any());

        foreach (var item in hangman.Consonants){
            gameState.CurrentQuestion.CurrentAnswer = gameState.CurrentQuestion.CurrentAnswer.Replace(item.Letter, PLACE_HOLDER);
        }

        // To make the layout better remove dashes before vowels
        //foreach (var item in hangman.Vowels)
        //{
            gameState.CurrentQuestion.CurrentAnswer = gameState.CurrentQuestion.CurrentAnswer.Replace(PLACE_HOLDER + "ਿ","ਿ" + PLACE_HOLDER);
        //}
    }

    private int CalculateScore(){
        if(gameState.AnsweredQuestions == null || gameState.AnsweredQuestions.Count > 0){
            return gameState.AnsweredQuestions.Sum(c => c.RemainingChances);
        }
        else{
            return 0;
        }
    }

    private void LetterClick(string letter)
    {
        if(!gameState.CurrentQuestion.Answer.Contains(letter) && !gameState.CurrentQuestion.LettersUsed.Contains(letter))
            gameState.CurrentQuestion.RemainingChances--;

        if(!gameState.CurrentQuestion.LettersUsed.Contains(letter))
            gameState.CurrentQuestion.LettersUsed.Add(letter);
        
        gameState.CurrentQuestion.CurrentAnswer = gameState.CurrentQuestion.Answer;

        foreach (var item in hangman.Consonants)
        {
            if(!gameState.CurrentQuestion.LettersUsed.Contains(item.Letter))
                gameState.CurrentQuestion.CurrentAnswer = gameState.CurrentQuestion.CurrentAnswer.Replace(item.Letter, PLACE_HOLDER);           
        }

        // To make the layout better remove dashes before vowels
//        foreach (var item in gameState.CurrentQuestion.CurrentAnswer)
//        {
            gameState.CurrentQuestion.CurrentAnswer = gameState.CurrentQuestion.CurrentAnswer.Replace(PLACE_HOLDER + "ਿ","ਿ" + PLACE_HOLDER);
//        }

        if(gameState.CurrentQuestion.CurrentAnswer == gameState.CurrentQuestion.Answer){
            gameState.CurrentQuestion.Status.Style = STATUS_STYLE_FINISHED_SUCCESS;
            gameState.CurrentQuestion.Status.Text = String.Format(STATUS_TEXT_FINISHED_SUCCESS, gameState.CurrentQuestion.Answer);
            gameState.AnsweredQuestions.Add(gameState.CurrentQuestion);
        }
        else if(gameState.CurrentQuestion.RemainingChances == 0){
            gameState.CurrentQuestion.Status.Style = STATUS_STYLE_FINISHED_FAILED;
            gameState.CurrentQuestion.Status.Text = String.Format(STATUS_TEXT_FINISHED_FAILED, gameState.CurrentQuestion.Answer);  
            gameState.AnsweredQuestions.Add(gameState.CurrentQuestion);
        }
    }

    private void OnNewQuestionClick(MouseEventArgs e)
    {
        NewQuestion();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
