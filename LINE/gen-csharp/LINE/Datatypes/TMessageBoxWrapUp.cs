/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace LINE.Datatypes
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TMessageBoxWrapUp : TBase
  {
    private TMessageBox _messageBox;
    private string _name;
    private List<Contact> _contacts;
    private string _pictureRevision;

    public TMessageBox MessageBox
    {
      get
      {
        return _messageBox;
      }
      set
      {
        __isset.messageBox = true;
        this._messageBox = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public List<Contact> Contacts
    {
      get
      {
        return _contacts;
      }
      set
      {
        __isset.contacts = true;
        this._contacts = value;
      }
    }

    public string PictureRevision
    {
      get
      {
        return _pictureRevision;
      }
      set
      {
        __isset.pictureRevision = true;
        this._pictureRevision = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool messageBox;
      public bool name;
      public bool contacts;
      public bool pictureRevision;
    }

    public TMessageBoxWrapUp() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              MessageBox = new TMessageBox();
              MessageBox.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                Contacts = new List<Contact>();
                TList _list73 = iprot.ReadListBegin();
                for( int _i74 = 0; _i74 < _list73.Count; ++_i74)
                {
                  Contact _elem75 = new Contact();
                  _elem75 = new Contact();
                  _elem75.Read(iprot);
                  Contacts.Add(_elem75);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              PictureRevision = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TMessageBoxWrapUp");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (MessageBox != null && __isset.messageBox) {
        field.Name = "messageBox";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        MessageBox.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (Contacts != null && __isset.contacts) {
        field.Name = "contacts";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Contacts.Count));
          foreach (Contact _iter76 in Contacts)
          {
            _iter76.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (PictureRevision != null && __isset.pictureRevision) {
        field.Name = "pictureRevision";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(PictureRevision);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TMessageBoxWrapUp(");
      sb.Append("MessageBox: ");
      sb.Append(MessageBox== null ? "<null>" : MessageBox.ToString());
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Contacts: ");
      sb.Append(Contacts);
      sb.Append(",PictureRevision: ");
      sb.Append(PictureRevision);
      sb.Append(")");
      return sb.ToString();
    }

  }

}