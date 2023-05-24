#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
// <console-tools-generated/>
#pragma warning restore SA1634 // File header should show copyright
#pragma warning restore IDE0079 // 请删除不必要的忽略
using static BD.WTTS.Settings.Abstractions.IProxySettings;

// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings;

[JsonSourceGenerationOptions(WriteIndented = true, IgnoreReadOnlyProperties = true)]
[JsonSerializable(typeof(ProxySettings_))]
internal partial class ProxySettingsContext : JsonSerializerContext
{
    static ProxySettingsContext? instance;

    public static ProxySettingsContext Instance
        => instance ??= new ProxySettingsContext(ISettings.GetDefaultOptions());
}

[MPObj, MP2Obj(SerializeLayout.Explicit)]
public sealed partial class ProxySettings_ : IProxySettings, ISettings, ISettings<ProxySettings_>
{
    public const string Name = nameof(ProxySettings);

    static string ISettings.Name => Name;

    static JsonSerializerContext ISettings.JsonSerializerContext
        => ProxySettingsContext.Instance;

    static JsonTypeInfo ISettings.JsonTypeInfo
        => ProxySettingsContext.Instance.ProxySettings_;

    static JsonTypeInfo<ProxySettings_> ISettings<ProxySettings_>.JsonTypeInfo
        => ProxySettingsContext.Instance.ProxySettings_;

    /// <summary>
    /// 启用脚本自动检查更新
    /// </summary>
    [MPKey(0), MP2Key(0), JsonPropertyOrder(0)]
    public bool? IsAutoCheckScriptUpdate { get; set; }

    /// <summary>
    /// 启用代理脚本
    /// </summary>
    [MPKey(1), MP2Key(1), JsonPropertyOrder(1)]
    public bool? IsEnableScript { get; set; }

    /// <summary>
    /// 代理服务启用状态
    /// </summary>
    [MPKey(2), MP2Key(2), JsonPropertyOrder(2)]
    public IReadOnlyCollection<string>? SupportProxyServicesStatus { get; set; }

    /// <summary>
    /// 脚本启用状态
    /// </summary>
    [MPKey(3), MP2Key(3), JsonPropertyOrder(3)]
    public IReadOnlyCollection<int>? ScriptsStatus { get; set; }

    #region 代理设置

    /// <summary>
    /// 程序启动时自动启动代理
    /// </summary>
    [MPKey(4), MP2Key(4), JsonPropertyOrder(4)]
    public bool? ProgramStartupRunProxy { get; set; }

    /// <summary>
    /// 系统代理模式端口
    /// </summary>
    [MPKey(5), MP2Key(5), JsonPropertyOrder(5)]
    public int? SystemProxyPortId { get; set; }

    /// <summary>
    /// 系统代理模式IP
    /// </summary>
    [MPKey(6), MP2Key(6), JsonPropertyOrder(6)]
    public string? SystemProxyIp { get; set; }

    /// <summary>
    /// 开启加速后仅代理脚本而不加速
    /// </summary>
    [MPKey(7), MP2Key(7), JsonPropertyOrder(7)]
    public bool? OnlyEnableProxyScript { get; set; }

    /// <summary>
    /// 代理时使用的解析主DNS
    /// </summary>
    [MPKey(8), MP2Key(8), JsonPropertyOrder(8)]
    public string? ProxyMasterDns { get; set; }

    /// <summary>
    /// 启用 Http 链接转发到 Https
    /// </summary>
    [MPKey(9), MP2Key(9), JsonPropertyOrder(9)]
    public bool? EnableHttpProxyToHttps { get; set; }

    #endregion

    #region 本地代理设置

    /// <summary>
    /// Socks5 Enable
    /// </summary>
    [MPKey(10), MP2Key(10), JsonPropertyOrder(10)]
    public bool? Socks5ProxyEnable { get; set; }

    /// <summary>
    /// Socks5 监听端口
    /// </summary>
    [MPKey(11), MP2Key(11), JsonPropertyOrder(11)]
    public int? Socks5ProxyPortId { get; set; }

    #endregion

    #region 二级代理设置

    /// <summary>
    /// TwoLevelAgent Enable
    /// </summary>
    [MPKey(12), MP2Key(12), JsonPropertyOrder(12)]
    public bool? TwoLevelAgentEnable { get; set; }

    /// <summary>
    /// TwoLevelAgent ProxyType
    /// </summary>
    [MPKey(13), MP2Key(13), JsonPropertyOrder(13)]
    public short? TwoLevelAgentProxyType { get; set; }

    /// <summary>
    /// 二级代理 IP
    /// </summary>
    [MPKey(14), MP2Key(14), JsonPropertyOrder(14)]
    public string? TwoLevelAgentIp { get; set; }

    /// <summary>
    /// 二级代理 监听端口
    /// </summary>
    [MPKey(15), MP2Key(15), JsonPropertyOrder(15)]
    public int? TwoLevelAgentPortId { get; set; }

    /// <summary>
    /// TwoLevelAgent UserName
    /// </summary>
    [MPKey(16), MP2Key(16), JsonPropertyOrder(16)]
    public string? TwoLevelAgentUserName { get; set; }

    /// <summary>
    /// TwoLevelAgent Password
    /// </summary>
    [MPKey(17), MP2Key(17), JsonPropertyOrder(17)]
    public string? TwoLevelAgentPassword { get; set; }

    #endregion

    #region 代理模式设置

    /// <summary>
    /// 当前代理模式
    /// </summary>
    [MPKey(18), MP2Key(18), JsonPropertyOrder(18)]
    public ProxyMode? ProxyMode { get; set; }

    #endregion

    /// <summary>
    /// 启用 GOG 插件代理
    /// </summary>
    [MPKey(19), MP2Key(19), JsonPropertyOrder(19)]
    public bool? IsProxyGOG { get; set; }

    /// <summary>
    /// 是否只针对 Steam 内置浏览器启用脚本
    /// </summary>
    [MPKey(20), MP2Key(20), JsonPropertyOrder(20)]
    public bool? IsOnlyWorkSteamBrowser { get; set; }

}

public static partial class ProxySettings
{
    /// <summary>
    /// 启用脚本自动检查更新
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsAutoCheckScriptUpdate { get; }
        = new(DefaultIsAutoCheckScriptUpdate);

    /// <summary>
    /// 启用代理脚本
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsEnableScript { get; }
        = new(DefaultIsEnableScript);

    /// <summary>
    /// 代理服务启用状态
    /// </summary>
    public static SettingsProperty<IReadOnlyCollection<string>, ProxySettings_> SupportProxyServicesStatus { get; }
        = new(DefaultSupportProxyServicesStatus);

    /// <summary>
    /// 脚本启用状态
    /// </summary>
    public static SettingsProperty<IReadOnlyCollection<int>, ProxySettings_> ScriptsStatus { get; }
        = new(DefaultScriptsStatus);

    #region 代理设置

    /// <summary>
    /// 程序启动时自动启动代理
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> ProgramStartupRunProxy { get; }
        = new(DefaultProgramStartupRunProxy);

    /// <summary>
    /// 系统代理模式端口
    /// </summary>
    public static SettingsStructProperty<int, ProxySettings_> SystemProxyPortId { get; }
        = new(DefaultSystemProxyPortId);

    /// <summary>
    /// 系统代理模式IP
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> SystemProxyIp { get; }
        = new(DefaultSystemProxyIp);

    /// <summary>
    /// 开启加速后仅代理脚本而不加速
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> OnlyEnableProxyScript { get; }
        = new(DefaultOnlyEnableProxyScript);

    /// <summary>
    /// 代理时使用的解析主DNS
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> ProxyMasterDns { get; }
        = new(DefaultProxyMasterDns);

    /// <summary>
    /// 启用 Http 链接转发到 Https
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> EnableHttpProxyToHttps { get; }
        = new(DefaultEnableHttpProxyToHttps);

    #endregion

    #region 本地代理设置

    /// <summary>
    /// Socks5 Enable
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> Socks5ProxyEnable { get; }
        = new(DefaultSocks5ProxyEnable);

    /// <summary>
    /// Socks5 监听端口
    /// </summary>
    public static SettingsStructProperty<int, ProxySettings_> Socks5ProxyPortId { get; }
        = new(DefaultSocks5ProxyPortId);

    #endregion

    #region 二级代理设置

    /// <summary>
    /// TwoLevelAgent Enable
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> TwoLevelAgentEnable { get; }
        = new(DefaultTwoLevelAgentEnable);

    /// <summary>
    /// TwoLevelAgent ProxyType
    /// </summary>
    public static SettingsStructProperty<short, ProxySettings_> TwoLevelAgentProxyType { get; }
        = new(DefaultTwoLevelAgentProxyType);

    /// <summary>
    /// 二级代理 IP
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> TwoLevelAgentIp { get; }
        = new(DefaultTwoLevelAgentIp);

    /// <summary>
    /// 二级代理 监听端口
    /// </summary>
    public static SettingsStructProperty<int, ProxySettings_> TwoLevelAgentPortId { get; }
        = new(DefaultTwoLevelAgentPortId);

    /// <summary>
    /// TwoLevelAgent UserName
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> TwoLevelAgentUserName { get; }
        = new(DefaultTwoLevelAgentUserName);

    /// <summary>
    /// TwoLevelAgent Password
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> TwoLevelAgentPassword { get; }
        = new(DefaultTwoLevelAgentPassword);

    #endregion

    #region 代理模式设置

    /// <summary>
    /// 当前代理模式
    /// </summary>
    public static SettingsStructProperty<ProxyMode, ProxySettings_> ProxyMode { get; }
        = new(DefaultProxyMode);

    #endregion

#if (WINDOWS || MACCATALYST || MACOS || LINUX) && !(IOS || ANDROID)

    /// <summary>
    /// 启用 GOG 插件代理
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsProxyGOG { get; }
        = new(DefaultIsProxyGOG);

    /// <summary>
    /// 是否只针对 Steam 内置浏览器启用脚本
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsOnlyWorkSteamBrowser { get; }
        = new(DefaultIsOnlyWorkSteamBrowser);

#endif

}
