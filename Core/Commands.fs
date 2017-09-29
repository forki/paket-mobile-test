namespace Core

open System
open System.Threading

 [<AllowNullLiteral>]
type IPlatformCommands =
    abstract member IsUIThread : bool
    abstract member RunOnUIThead : (unit -> unit) -> unit
    abstract member GetUIThreadContext : unit -> SynchronizationContext Async
   