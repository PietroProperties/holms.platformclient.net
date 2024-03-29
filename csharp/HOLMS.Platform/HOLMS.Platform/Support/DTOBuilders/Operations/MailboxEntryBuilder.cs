﻿using System;
using System.Collections.Generic;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Types.IAM;
using HOLMS.Types.Operations.Messaging;

namespace HOLMS.Platform.Support.DTOBuilders.Operations {
    public class MailboxEntryBuilder {
        private readonly MailboxEntryIndicator _ind;
        private readonly string _subject;
        private readonly string _body;
        private readonly StaffMember _sender;
        private readonly List<StaffMember> _recipients;
        private readonly DateTime? _viewedAt;
        private readonly DateTime _createdAt;
        private readonly string _messageId;

        public MailboxEntryBuilder(MailboxEntryIndicator ind, string subject, string body,
            StaffMember sender, IEnumerable<StaffMember> recipients, string Id, DateTime? viewedAt,
            DateTime createdAt) {
            _ind = ind;
            _subject = subject;
            _body = body;
            _sender = sender;
            _recipients = new List<StaffMember>(recipients);
            _viewedAt = viewedAt;
            _createdAt = createdAt;
            _messageId = Id;
        }

        public MailboxEntry Build() {
            var mbe = new MailboxEntry {
                EntityId = _ind,
                Body = _body ?? string.Empty,
                CreatedAt = _createdAt.ToTS(),
                Subject = _subject ?? string.Empty,
                MessageId = _messageId ?? string.Empty
            };

            if (_viewedAt.HasValue) {
                mbe.ViewedAt = _viewedAt.Value.ToTS();
            }

            if (_sender != null) {
                mbe.Sender = _sender;
            }

            if (_recipients != null) {
                mbe.Recipients.Add(_recipients);
            }

            return mbe;
        }
    }
}
