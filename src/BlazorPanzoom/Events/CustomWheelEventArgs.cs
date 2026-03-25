namespace BlazorPanzoom
{
    public record CustomWheelEventArgs (
        double DeltaX,
        double DeltaY,
        double ClientX,
        double ClientY,
        bool ShiftKey,
        bool AltKey,
        bool CtrlKey) : IBlazorPanzoomEvent;
}