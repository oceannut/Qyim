using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{

    [DataContract]
    public class DataError
    {

        private static readonly Dictionary<DataErrorCode, ErrorHandleAdvice> codeTypeDict = new Dictionary<DataErrorCode, ErrorHandleAdvice>();

        [DataMember]
        public DataErrorCode Code { get; private set; }

        [DataMember]
        public ErrorHandleAdvice Advice { get; private set; }

        [DataMember]
        public string Description { get; set; }

        static DataError()
        {
            codeTypeDict.Add(DataErrorCode.BadRequest, ErrorHandleAdvice.Modify);
            codeTypeDict.Add(DataErrorCode.UnexpectedRequest, ErrorHandleAdvice.Modify);
            codeTypeDict.Add(DataErrorCode.Conflict, ErrorHandleAdvice.Cancel);
            codeTypeDict.Add(DataErrorCode.FeatureNotImplemented, ErrorHandleAdvice.Cancel);
            codeTypeDict.Add(DataErrorCode.Forbidden, ErrorHandleAdvice.Auth);
            codeTypeDict.Add(DataErrorCode.InternalServerError, ErrorHandleAdvice.Cancel);
            codeTypeDict.Add(DataErrorCode.ObjectNotFound, ErrorHandleAdvice.Cancel);
            codeTypeDict.Add(DataErrorCode.NotAcceptable, ErrorHandleAdvice.Modify);
            codeTypeDict.Add(DataErrorCode.NotAllowed, ErrorHandleAdvice.Cancel);
            codeTypeDict.Add(DataErrorCode.NotAuthorized, ErrorHandleAdvice.Auth);
            codeTypeDict.Add(DataErrorCode.RecipientUnavailable, ErrorHandleAdvice.Wait);
            codeTypeDict.Add(DataErrorCode.RemoteServerNotFound, ErrorHandleAdvice.Cancel);
            codeTypeDict.Add(DataErrorCode.RemoteServerTimeout, ErrorHandleAdvice.Wait);
            codeTypeDict.Add(DataErrorCode.ResourceConstraint, ErrorHandleAdvice.Wait);
            codeTypeDict.Add(DataErrorCode.ServiceUnavailable, ErrorHandleAdvice.Wait);
        }

        public DataError(DataErrorCode code)
        {
            this.Code = code;
            ErrorHandleAdvice advice;
            codeTypeDict.TryGetValue(this.Code, out advice);
            this.Advice = advice;
        }

        public DataError(DataErrorCode code, string desc)
            : this(code)
        {
            this.Description = desc;
        }

        /// <summary>
        /// <ul>
        ///     <li>DataError.Type.Wait - retry after waiting (the error is temporary)
        ///     <li>DataError.Type.Cancel - do not retry (the error is unrecoverable)
        ///     <li>DataError.Type.Modify - retry after changing the data sent
        ///     <li>DataError.Type.Auth - retry after providing credentials
        ///     <li>DataError.Type.Continue - proceed (the condition was only a warning)
        /// </ul>
        /// </summary>
        public enum ErrorHandleAdvice
        {
            Wait,
            Cancel,
            Modify,
            Auth,
            Continue
        }

        public enum DataErrorCode
        {
            BadRequest,
            UnexpectedRequest,
            Conflict,
            FeatureNotImplemented,
            Forbidden,
            InternalServerError,
            ObjectNotFound,
            NotAcceptable,
            NotAllowed,
            NotAuthorized,
            RecipientUnavailable,
            RemoteServerNotFound,
            RemoteServerTimeout,
            ResourceConstraint,
            ServiceUnavailable
        }

    }

}
