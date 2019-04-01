// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/monitoring/v3/dropped_labels.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Monitoring.V3 {

  /// <summary>Holder for reflection information generated from google/monitoring/v3/dropped_labels.proto</summary>
  public static partial class DroppedLabelsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/monitoring/v3/dropped_labels.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DroppedLabelsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvbW9uaXRvcmluZy92My9kcm9wcGVkX2xhYmVscy5wcm90bxIU",
            "Z29vZ2xlLm1vbml0b3JpbmcudjMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8ifAoNRHJvcHBlZExhYmVscxI9CgVsYWJlbBgBIAMoCzIuLmdvb2ds",
            "ZS5tb25pdG9yaW5nLnYzLkRyb3BwZWRMYWJlbHMuTGFiZWxFbnRyeRosCgpM",
            "YWJlbEVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAFCcAoY",
            "Y29tLmdvb2dsZS5tb25pdG9yaW5nLnYzQhJEcm9wcGVkTGFiZWxzUHJvdG9Q",
            "AVo+Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9tb25p",
            "dG9yaW5nL3YzO21vbml0b3JpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Monitoring.V3.DroppedLabels), global::Google.Monitoring.V3.DroppedLabels.Parser, new[]{ "Label" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A set of (label, value) pairs which were dropped during aggregation, attached
  /// to google.api.Distribution.Exemplars in google.api.Distribution values during
  /// aggregation.
  ///
  /// These values are used in combination with the label values that remain on the
  /// aggregated Distribution timeseries to construct the full label set for the
  /// exemplar values.  The resulting full label set may be used to identify the
  /// specific task/job/instance (for example) which may be contributing to a
  /// long-tail, while allowing the storage savings of only storing aggregated
  /// distribution values for a large group.
  ///
  /// Note that there are no guarantees on ordering of the labels from
  /// exemplar-to-exemplar and from distribution-to-distribution in the same
  /// stream, and there may be duplicates.  It is up to clients to resolve any
  /// ambiguities.
  /// </summary>
  public sealed partial class DroppedLabels : pb::IMessage<DroppedLabels> {
    private static readonly pb::MessageParser<DroppedLabels> _parser = new pb::MessageParser<DroppedLabels>(() => new DroppedLabels());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DroppedLabels> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Monitoring.V3.DroppedLabelsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedLabels() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedLabels(DroppedLabels other) : this() {
      label_ = other.label_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedLabels Clone() {
      return new DroppedLabels(this);
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_label_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 10);
    private readonly pbc::MapField<string, string> label_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Map from label to its value, for all labels dropped in any aggregation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Label {
      get { return label_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DroppedLabels);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DroppedLabels other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Label.Equals(other.Label)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Label.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      label_.WriteTo(output, _map_label_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += label_.CalculateSize(_map_label_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DroppedLabels other) {
      if (other == null) {
        return;
      }
      label_.Add(other.label_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            label_.AddEntriesFrom(input, _map_label_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code