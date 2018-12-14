namespace Gao.Model.Libre
{
    /// <summary>
    /// Unexpected events change the flow of the story.
    /// </summary>
    public class UnexpectedEvent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Comment Comment { get; set; }
        public UnexpectedEventType Type { get; set; }
        public UnexpectedEventFocusType? FocusType { get; set; }
        public LocationAndQualityType? SuggestedRationale { get; set; }
        public Trait? SuggestedTrait { get; set; }
    }
}
