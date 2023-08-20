using lib.dependency.inject.constructor;
using lib.dependency.inject.method;
using lib.dependency.inject.property;

#region Constructor Injection sample - 1
ILogManager logManager = new LogManager(new FileLogger());
new LogConsumeOne(logManager).Test();
new LogConsumeTwo(logManager).Test();
#endregion

#region Property Injection sample
PayManager payManager = new PayManager
{
    SetPayment = new PayWithCash()
};
PayManager.Pay();
#endregion

#region Method Injection sample
MessageManager.SendMessage(new SendMessageBySms());
#endregion