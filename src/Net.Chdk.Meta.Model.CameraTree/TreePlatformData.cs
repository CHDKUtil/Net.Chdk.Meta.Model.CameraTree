namespace Net.Chdk.Meta.Model.CameraTree
{
    public sealed class TreePlatformData : PlatformData<TreePlatformData, TreeRevisionData, TreeSourceData>
    {
        public TreeEncodingData Encoding { get; set; }
        public TreeCardData Card { get; set; }
        public TreeAltData Alt { get; set; }
    }
}
