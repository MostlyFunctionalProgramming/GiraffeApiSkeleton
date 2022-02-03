namespace GiraffeApi

module HttpHandlers =

  open Microsoft.AspNetCore.Http
  open FSharp.Control.Tasks
  open Giraffe
  open GiraffeApi.Models

  let handleGetHello name =
    fun (next: HttpFunc) (ctx: HttpContext) ->
      task {
        let response =
          { Text = $"Hello {name}, from Giraffe!" }

        return! json response next ctx
      }

  let handlePostOops =
    fun (next: HttpFunc) (ctx: HttpContext) -> failwith "oops what happened?"
// fun (next: HttpFunc) (ctx: HttpContext) ->
//   task {
//     let response = { Text = "oops" }
//     do ctx.SetStatusCode 500
//     return! json response next ctx
//   }
