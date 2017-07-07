namespace Net.Chdk.Meta.Model.CameraTree
{
    public sealed class TreeRevisionData : RevisionData<TreeRevisionData, TreeSourceData>
    {
        public TreeEncodingData Encoding { get; set; }
    }
}
