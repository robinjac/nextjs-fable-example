module App.Page

open Feliz
open Fable.Core.JsInterop

[<ReactComponent>]
let Page () =
    Html.div [
        Html.span "Hello, world"
    ]

exportDefault Page