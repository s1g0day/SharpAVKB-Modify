using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SharpAVKB
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("\n\rAuthor: s1g0day");
                Console.WriteLine("Github: https://github.com/s1g0day/SharpAVKB-Modify/SharpAVKB-v1/");
                Console.WriteLine("Usage: SharpAVKB.exe -AV");

            }
            if (args.Length == 1 && args[0] == "-AV")
            {
                Console.WriteLine("\n\r========== SharpAVKB --> GetWindowsAnti-VirusSoftware ==========\n\r");
                av();
            }
        }


        public static void av()
        {

            Dictionary<string, string> av_list = new Dictionary<string, string>();
            av_list.Add("360tray.exe", "360安全卫士-实时保护");
            av_list.Add("360safe.exe", "360安全卫士-主程序");
            av_list.Add("ZhuDongFangYu.exe", "360安全卫士-主动防御");
            av_list.Add("360sd.exe", "360杀毒");
            av_list.Add("a2guard.exe", "a-squared杀毒");
            av_list.Add("ad-watch.exe", "Lavasoft杀毒");
            av_list.Add("cleaner8.exe", "The Cleaner杀毒");
            av_list.Add("vba32lder.exe", "vb32杀毒");
            av_list.Add("MongoosaGUI.exe", "Mongoosa杀毒");
            av_list.Add("CorantiControlCenter32.exe", "Coranti2012杀毒");
            av_list.Add("F-PROT.exe", "F-Prot AntiVirus");
            av_list.Add("CMCTrayIcon.exe", "CMC杀毒");
            av_list.Add("K7TSecurity.exe", "K7杀毒");
            av_list.Add("UnThreat.exe", "UnThreat杀毒");
            av_list.Add("CKSoftShiedAntivirus4.exe", "Shield Antivirus杀毒");
            av_list.Add("AVWatchService.exe", "VIRUSfighter杀毒");
            av_list.Add("ArcaTasksService.exe", "ArcaVir杀毒");
            av_list.Add("iptray.exe", "Immunet杀毒");
            av_list.Add("PSafeSysTray.exe", "PSafe杀毒");
            av_list.Add("nspupsvc.exe", "nProtect杀毒");
            av_list.Add("SpywareTerminatorShield.exe", "SpywareTerminator反间谍软件");
            av_list.Add("BKavService.exe", "Bkav杀毒");
            av_list.Add("MsMpEng.exe", "Windows Defender");
            av_list.Add("SBAMSvc.exe", "VIPRE");
            av_list.Add("ccSvcHst.exe", "Norton杀毒");
            av_list.Add("f-secure.exe", "冰岛");
            av_list.Add("avp.exe", "Kaspersky");
            av_list.Add("KvMonXP.exe", "江民杀毒");
            av_list.Add("RavMonD.exe", "瑞星杀毒");
            av_list.Add("Mcshield.exe", "McAfee");
            av_list.Add("Tbmon.exe", "McAfee");
            av_list.Add("Frameworkservice.exe", "McAfee");
            av_list.Add("egui.exe", "ESET NOD32");
            av_list.Add("ekrn.exe", "ESET NOD32");
            av_list.Add("eguiProxy.exe", "ESET NOD32");
            av_list.Add("kxetray.exe", "金山毒霸");
            av_list.Add("knsdtray.exe", "可牛杀毒");
            av_list.Add("TMBMSRV.exe", "趋势杀毒");
            av_list.Add("avcenter.exe", "Avira(小红伞)");
            av_list.Add("avguard.exe", "Avira(小红伞)");
            av_list.Add("avgnt.exe", "Avira(小红伞)");
            av_list.Add("sched.exe", "Avira(小红伞)");
            av_list.Add("ashDisp.exe", "Avast网络安全");
            av_list.Add("rtvscan.exe", "诺顿杀毒");
            av_list.Add("ccapp.exe", "SymantecNorton");
            av_list.Add("NPFMntor.exe", "Norton杀毒软件");
            av_list.Add("ccSetMgr.exe", "赛门铁克");
            av_list.Add("ccRegVfy.exe", "Norton杀毒软件");
            av_list.Add("ksafe.exe", "金山卫士");
            av_list.Add("QQPCRTP.exe", "QQ电脑管家");
            av_list.Add("avgwdsvc.exe", "AVG杀毒");
            av_list.Add("QUHLPSVC.exe", "QUICK HEAL杀毒");
            av_list.Add("mssecess.exe", "微软杀毒");
            av_list.Add("SavProgress.exe", "Sophos杀毒");
            av_list.Add("SophosUI.exe", "Sophos杀毒");
            av_list.Add("SophosFS.exe", "Sophos杀毒");
            av_list.Add("SophosHealth.exe", "Sophos杀毒");
            av_list.Add("SophosSafestore64.exe", "Sophos杀毒");
            av_list.Add("SophosCleanM.exe", "Sophos杀毒");
            av_list.Add("fsavgui.exe", "F-Secure杀毒");
            av_list.Add("vsserv.exe", "比特梵德");
            av_list.Add("remupd.exe", "熊猫卫士");
            av_list.Add("FortiTray.exe", "飞塔");
            av_list.Add("safedog.exe", "安全狗");
            av_list.Add("parmor.exe", "木马克星");
            av_list.Add("Iparmor.exe.exe", "木马克星");
            av_list.Add("beikesan.exe", "贝壳云安全");
            av_list.Add("KSWebShield.exe", "金山网盾");
            av_list.Add("TrojanHunter.exe", "木马猎手");
            av_list.Add("GG.exe", "巨盾网游安全盾");
            av_list.Add("adam.exe", "绿鹰安全精灵");
            av_list.Add("AST.exe", "超级巡警");
            av_list.Add("ananwidget.exe", "墨者安全专家");
            av_list.Add("AVK.exe", "AntiVirusKit");
            av_list.Add("avg.exe", "AVG Anti-Virus");
            av_list.Add("spidernt.exe", "Dr.web");
            av_list.Add("avgaurd.exe", "Avira Antivir");
            av_list.Add("vsmon.exe", "Zone Alarm");
            av_list.Add("cpf.exe", "ComodoAnti-virus");
            av_list.Add("outpost.exe", "Outpost Firewall");
            av_list.Add("rfwmain.exe", "瑞星防火墙");
            av_list.Add("kpfwtray.exe", "金山网镖");
            av_list.Add("FYFireWall.exe", "风云防火墙");
            av_list.Add("MPMon.exe", "微点主动防御");
            av_list.Add("pfw.exe", "天网防火墙");
            av_list.Add("BaiduSdSvc.exe", "百度杀毒-服务进程");
            av_list.Add("BaiduSdTray.exe", "百度杀毒-托盘进程");
            av_list.Add("BaiduSd.exe", "百度杀毒-主程序");
            av_list.Add("SafeDogGuardCenter.exe", "安全狗");
            av_list.Add("safedogupdatecenter.exe", "安全狗");
            av_list.Add("safedogguardcenter.exe", "安全狗");
            av_list.Add("SafeDogSiteIIS.exe", "安全狗");
            av_list.Add("SafeDogTray.exe", "安全狗");
            av_list.Add("SafeDogServerUI.exe", "安全狗");
            av_list.Add("D_Safe_Manage.exe", "D盾");
            av_list.Add("d_manage.exe", "D盾");
            av_list.Add("yunsuo_agent_service.exe", "云锁");
            av_list.Add("yunsuo_agent_daemon.exe", "云锁");
            av_list.Add("HwsPanel.exe", "护卫神");
            av_list.Add("hws_ui.exe", "护卫神");
            av_list.Add("hws.exe", "护卫神");
            av_list.Add("hwsd.exe", "护卫神");
            av_list.Add("hipstray.exe", "火绒");
            av_list.Add("wsctrl.exe", "火绒");
            av_list.Add("usysdiag.exe", "火绒");
            av_list.Add("SPHINX.exe", "SPHINX防火墙");
            av_list.Add("bddownloader.exe", "百度卫士");
            av_list.Add("baiduansvx.exe", "百度卫士-主进程");
            av_list.Add("AvastUI.exe", "Avast!5主程序");
            av_list.Add("emet_agent.exe", "EMET");
            av_list.Add("emet_service.exe", "EMET");
            av_list.Add("firesvc.exe", "McAfee");
            av_list.Add("firetray.exe", "McAfee");
            av_list.Add("hipsvc.exe", "McAfee");
            av_list.Add("mfevtps.exe", "McAfee");
            av_list.Add("mcafeefire.exe", "McAfee");
            av_list.Add("scan32.exe", "McAfee");
            av_list.Add("shstat.exe", "McAfee");
            av_list.Add("vstskmgr.exe", "McAfee");
            av_list.Add("engineserver.exe", "McAfee");
            av_list.Add("mfeann.exe", "McAfee");
            av_list.Add("mcscript.exe", "McAfee");
            av_list.Add("updaterui.exe", "McAfee");
            av_list.Add("udaterui.exe", "McAfee");
            av_list.Add("naprdmgr.exe", "McAfee");
            av_list.Add("cleanup.exe", "McAfee");
            av_list.Add("cmdagent.exe", "McAfee");
            av_list.Add("frminst.exe", "McAfee");
            av_list.Add("mcscript_inuse.exe", "McAfee");
            av_list.Add("mctray.exe", "McAfee");
            av_list.Add("_avp32.exe", "卡巴斯基");
            av_list.Add("_avpcc.exe", "卡巴斯基");
            av_list.Add("_avpm.exe", "卡巴斯基");
            av_list.Add("aAvgApi.exe", "AVG");
            av_list.Add("ackwin32.exe", "已知杀软进程名称暂未收录");
            av_list.Add("alertsvc.exe", "Norton AntiVirus");
            av_list.Add("alogserv.exe", "McAfee VirusScan");
            av_list.Add("anti-trojan.exe", "Anti-Trojan Elite");
            av_list.Add("arr.exe", "Application Request Route");
            av_list.Add("atguard.exe", "AntiVir");
            av_list.Add("atupdater.exe", "已知杀软进程名称暂未收录");
            av_list.Add("atwatch.exe", "Mustek");
            av_list.Add("au.exe", "NSIS");
            av_list.Add("aupdate.exe", "Symantec");
            av_list.Add("auto-protect.nav80try.exe", "已知杀软进程名称暂未收录");
            av_list.Add("autodown.exe", "AntiVirus AutoUpdater");
            av_list.Add("avconsol.exe", "McAfee");
            av_list.Add("avgcc32.exe", "AVG");
            av_list.Add("avgctrl.exe", "AVG");
            av_list.Add("avgemc.exe", "AVG");
            av_list.Add("avgrsx.exe", "AVG");
            av_list.Add("avgserv.exe", "AVG");
            av_list.Add("avgserv9.exe", "AVG");
            av_list.Add("avgw.exe", "AVG");
            av_list.Add("avkpop.exe", "G DATA SOFTWARE AG");
            av_list.Add("avkserv.exe", "G DATA SOFTWARE AG");
            av_list.Add("avkservice.exe", "G DATA SOFTWARE AG");
            av_list.Add("avkwctl9.exe", "G DATA SOFTWARE AG");
            av_list.Add("avltmain.exe", "Panda Software Aplication");
            av_list.Add("avnt.exe", "H+BEDV Datentechnik GmbH");
            av_list.Add("avp32.exe", "Kaspersky Anti-Virus");
            av_list.Add("avpcc.exe", " Kaspersky AntiVirus");
            av_list.Add("avpdos32.exe", " Kaspersky AntiVirus");
            av_list.Add("avpm.exe", " Kaspersky AntiVirus");
            av_list.Add("avptc32.exe", " Kaspersky AntiVirus");
            av_list.Add("avpupd.exe", " Kaspersky AntiVirus");
            av_list.Add("avsynmgr.exe", "McAfee");
            av_list.Add("avwin.exe", " H+BEDV");
            av_list.Add("bargains.exe", "Exact Advertising SpyWare");
            av_list.Add("beagle.exe", "Avast");
            av_list.Add("blackd.exe", "BlackICE");
            av_list.Add("blackice.exe", "BlackICE");
            av_list.Add("blink.exe", "micromedia");
            av_list.Add("blss.exe", "CBlaster");
            av_list.Add("bootwarn.exe", "Symantec");
            av_list.Add("bpc.exe", "Grokster");
            av_list.Add("brasil.exe", "Exact Advertising");
            av_list.Add("ccevtmgr.exe", "Norton Internet Security");
            av_list.Add("cdp.exe", "CyberLink Corp.");
            av_list.Add("cfd.exe", "Motive Communications");
            av_list.Add("cfgwiz.exe", " Norton AntiVirus");
            av_list.Add("claw95.exe", "已知杀软进程名称暂未收录");
            av_list.Add("claw95cf.exe", "已知杀软进程名称暂未收录");
            av_list.Add("clean.exe", "windows流氓软件清理大师");
            av_list.Add("cleaner.exe", "windows流氓软件清理大师");
            av_list.Add("cleaner3.exe", "windows流氓软件清理大师");
            av_list.Add("cleanpc.exe", "windows流氓软件清理大师");
            av_list.Add("cpd.exe", "McAfee");
            av_list.Add("ctrl.exe", "已知杀软进程名称暂未收录");
            av_list.Add("cv.exe", "已知杀软进程名称暂未收录");
            av_list.Add("defalert.exe", "Symantec");
            av_list.Add("defscangui.exe", "Symantec");
            av_list.Add("defwatch.exe", "Norton Antivirus");
            av_list.Add("doors.exe", "已知杀软进程名称暂未收录");
            av_list.Add("dpf.exe", "已知杀软进程名称暂未收录");
            av_list.Add("dpps2.exe", "PanicWare");
            av_list.Add("dssagent.exe", "Broderbund");
            av_list.Add("ecengine.exe", "已知杀软进程名称暂未收录");
            av_list.Add("emsw.exe", "Alset Inc");
            av_list.Add("ent.exe", " ['已知杀软进程名称暂未收录', 'EMET', 'Broderbund', 'McAfee', '天擎EDRAgent', '深信服EDRAgent', '天眼云镜', '蓝鲸Agent']");
            av_list.Add("espwatch.exe", "已知杀软进程名称暂未收录");
            av_list.Add("ethereal.exe", "RationalClearCase");
            av_list.Add("exe.avxw.exe", "已知杀软进程名称暂未收录");
            av_list.Add("expert.exe", "已知杀软进程名称暂未收录");
            av_list.Add("f-prot95.exe", "已知杀软进程名称暂未收录");
            av_list.Add("fameh32.exe", "F-Secure");
            av_list.Add("fast.exe", " FastUsr");
            av_list.Add("fch32.exe", "F-Secure");
            av_list.Add("fih32.exe", "F-Secure");
            av_list.Add("findviru.exe", "F-Secure");
            av_list.Add("firewall.exe", "AshampooSoftware");
            av_list.Add("fnrb32.exe", "F-Secure");
            av_list.Add("fp-win.exe", " F-Prot Antivirus OnDemand");
            av_list.Add("fsaa.exe", "F-Secure");
            av_list.Add("fsav.exe", "F-Secure");
            av_list.Add("fsav32.exe", "F-Secure");
            av_list.Add("fsav530stbyb.exe", "F-Secure");
            av_list.Add("fsav530wtbyb.exe", "F-Secure");
            av_list.Add("fsav95.exe", "F-Secure");
            av_list.Add("fsgk32.exe", "F-Secure");
            av_list.Add("fsm32.exe", "F-Secure");
            av_list.Add("fsma32.exe", "F-Secure");
            av_list.Add("fsmb32.exe", "F-Secure");
            av_list.Add("gbmenu.exe", "已知杀软进程名称暂未收录");
            av_list.Add("guard.exe", "ewido");
            av_list.Add("guarddog.exe", "ewido");
            av_list.Add("htlog.exe", "已知杀软进程名称暂未收录");
            av_list.Add("htpatch.exe", "Silicon Integrated Systems Corporation");
            av_list.Add("hwpe.exe", "已知杀软进程名称暂未收录");
            av_list.Add("iamapp.exe", "Symantec");
            av_list.Add("iamserv.exe", "Symantec");
            av_list.Add("iamstats.exe", "Symantec");
            av_list.Add("iedriver.exe", " Urlblaze.com");
            av_list.Add("iface.exe", "Panda Antivirus Module");
            av_list.Add("infus.exe", "Infus Dialer");
            av_list.Add("infwin.exe", "Msviewparasite");
            av_list.Add("intdel.exe", "Inet Delivery");
            av_list.Add("intren.exe", "已知杀软进程名称暂未收录");
            av_list.Add("jammer.exe", "已知杀软进程名称暂未收录");
            av_list.Add("kavpf.exe", "Kapersky");
            av_list.Add("kazza.exe", "Kapersky");
            av_list.Add("keenvalue.exe", "EUNIVERSE INC");
            av_list.Add("launcher.exe", "Intercort Systems");
            av_list.Add("ldpro.exe", "已知杀软进程名称暂未收录");
            av_list.Add("ldscan.exe", "Windows Trojans Inspector");
            av_list.Add("localnet.exe", "已知杀软进程名称暂未收录");
            av_list.Add("luall.exe", "Symantec");
            av_list.Add("luau.exe", "Symantec");
            av_list.Add("lucomserver.exe", "Norton");
            av_list.Add("mcagent.exe", "McAfee");
            av_list.Add("mcmnhdlr.exe", "McAfee");
            av_list.Add("mctool.exe", "McAfee");
            av_list.Add("mcupdate.exe", "McAfee");
            av_list.Add("mcvsrte.exe", "McAfee");
            av_list.Add("mcvsshld.exe", "McAfee");
            av_list.Add("mfin32.exe", "MyFreeInternetUpdate");
            av_list.Add("mfw2en.exe", "MyFreeInternetUpdate");
            av_list.Add("mfweng3.02d30.exe", "MyFreeInternetUpdate");
            av_list.Add("mgavrtcl.exe", "McAfee");
            av_list.Add("mgavrte.exe", "McAfee");
            av_list.Add("mghtml.exe", "McAfee");
            av_list.Add("mgui.exe", "BullGuard");
            av_list.Add("minilog.exe", "Zone Labs Inc");
            av_list.Add("mmod.exe", "EzulaInc");
            av_list.Add("mostat.exe", "WurldMediaInc");
            av_list.Add("mpfagent.exe", "McAfee");
            av_list.Add("mpfservice.exe", "McAfee");
            av_list.Add("mpftray.exe", "McAfee");
            av_list.Add("mscache.exe", "Integrated Search Technologies Spyware");
            av_list.Add("mscman.exe", "OdysseusMarketingInc");
            av_list.Add("msmgt.exe", "Total Velocity Spyware");
            av_list.Add("msvxd.exe", "W32/Datom-A");
            av_list.Add("mwatch.exe", "已知杀软进程名称暂未收录");
            av_list.Add("nav.exe", "Reuters Limited");
            av_list.Add("navapsvc.exe", "Norton AntiVirus");
            av_list.Add("navapw32.exe", "Norton AntiVirus");
            av_list.Add("navw32.exe", "Norton Antivirus");
            av_list.Add("ndd32.exe", "诺顿磁盘医生");
            av_list.Add("neowatchlog.exe", "已知杀软进程名称暂未收录");
            av_list.Add("netutils.exe", "已知杀软进程名称暂未收录");
            av_list.Add("nisserv.exe", "Norton");
            av_list.Add("nisum.exe", "Norton");
            av_list.Add("nmain.exe", "Norton");
            av_list.Add("nod32.exe", "ESET Smart Security");
            av_list.Add("norton_internet_secu_3.0_407.exe", "已知杀软进程名称暂未收录");
            av_list.Add("notstart.exe", "已知杀软进程名称暂未收录");
            av_list.Add("nprotect.exe", "Symantec");
            av_list.Add("npscheck.exe", "Norton");
            av_list.Add("npssvc.exe", "Norton");
            av_list.Add("ntrtscan.exe", "趋势反病毒应用程序");
            av_list.Add("nui.exe", "已知杀软进程名称暂未收录");
            av_list.Add("otfix.exe", "已知杀软进程名称暂未收录");
            av_list.Add("outpostinstall.exe", "Outpost");
            av_list.Add("patch.exe", "趋势科技");
            av_list.Add("pavw.exe", "已知杀软进程名称暂未收录");
            av_list.Add("pcscan.exe", "趋势科技");
            av_list.Add("pdsetup.exe", "已知杀软进程名称暂未收录");
            av_list.Add("persfw.exe", "Tiny Personal Firewall");
            av_list.Add("pgmonitr.exe", "PromulGate SpyWare");
            av_list.Add("pingscan.exe", "已知杀软进程名称暂未收录");
            av_list.Add("platin.exe", "已知杀软进程名称暂未收录");
            av_list.Add("pop3trap.exe", "PC-cillin");
            av_list.Add("poproxy.exe", "NortonAntiVirus");
            av_list.Add("popscan.exe", "已知杀软进程名称暂未收录");
            av_list.Add("powerscan.exe", "Integrated Search Technologies");
            av_list.Add("ppinupdt.exe", "已知杀软进程名称暂未收录");
            av_list.Add("pptbc.exe", "已知杀软进程名称暂未收录");
            av_list.Add("ppvstop.exe", "已知杀软进程名称暂未收录");
            av_list.Add("prizesurfer.exe", "Prizesurfer");
            av_list.Add("prmt.exe", "OpiStat");
            av_list.Add("prmvr.exe", "Adtomi");
            av_list.Add("processmonitor.exe", "Sysinternals");
            av_list.Add("proport.exe", "已知杀软进程名称暂未收录");
            av_list.Add("protectx.exe", "ProtectX");
            av_list.Add("pspf.exe", "已知杀软进程名称暂未收录");
            av_list.Add("purge.exe", "已知杀软进程名称暂未收录");
            av_list.Add("qconsole.exe", "Norton AntiVirus Quarantine Console");
            av_list.Add("qserver.exe", "Norton Internet Security");
            av_list.Add("rapapp.exe", "BlackICE");
            av_list.Add("rb32.exe", "RapidBlaster");
            av_list.Add("rcsync.exe", "PrizeSurfer");
            av_list.Add("realmon.exe", "Realmon ");
            av_list.Add("rescue.exe", "已知杀软进程名称暂未收录");
            av_list.Add("rescue32.exe", "卡巴斯基互联网安全套装");
            av_list.Add("rshell.exe", "已知杀软进程名称暂未收录");
            av_list.Add("rtvscn95.exe", "Real-time virus scanner ");
            av_list.Add("rulaunch.exe", "McAfee User Interface");
            av_list.Add("run32dll.exe", "PAL PC Spy");
            av_list.Add("safeweb.exe", "PSafe Tecnologia");
            av_list.Add("sbserv.exe", "Norton Antivirus");
            av_list.Add("scrscan.exe", "360杀毒");
            av_list.Add("sfc.exe", "System file checker");
            av_list.Add("sh.exe", "MKS Toolkit for Win3");
            av_list.Add("showbehind.exe", "MicroSmarts Enterprise Component ");
            av_list.Add("soap.exe", "System Soap Pro");
            av_list.Add("sofi.exe", "已知杀软进程名称暂未收录");
            av_list.Add("sperm.exe", "已知杀软进程名称暂未收录");
            av_list.Add("supporter5.exe", "eScorcher反病毒");
            av_list.Add("symproxysvc.exe", "Symantec");
            av_list.Add("symtray.exe", "Symantec");
            av_list.Add("tbscan.exe", "ThunderBYTE");
            av_list.Add("tc.exe", "TimeCalende");
            av_list.Add("titanin.exe", "TitanHide");
            av_list.Add("tvmd.exe", "Total Velocity");
            av_list.Add("tvtmd.exe", " Total Velocity");
            av_list.Add("vettray.exe", "eTrust");
            av_list.Add("vir-help.exe", "已知杀软进程名称暂未收录");
            av_list.Add("vnpc3000.exe", "已知杀软进程名称暂未收录");
            av_list.Add("vpc32.exe", "Symantec");
            av_list.Add("vpc42.exe", "Symantec");
            av_list.Add("vshwin32.exe", "McAfee");
            av_list.Add("vsmain.exe", "McAfee");
            av_list.Add("vsstat.exe", "McAfee");
            av_list.Add("wfindv32.exe", "已知杀软进程名称暂未收录");
            av_list.Add("zapro.exe", "Zone Alarm");
            av_list.Add("zonealarm.exe", "Zone Alarm");
            av_list.Add("AVPM.exe", "Kaspersky");
            av_list.Add("A2CMD.exe", "Emsisoft Anti-Malware");
            av_list.Add("A2SERVICE.exe", "a-squared free");
            av_list.Add("A2FREE.exe", "a-squared Free");
            av_list.Add("ADVCHK.exe", "Norton AntiVirus");
            av_list.Add("AGB.exe", "安天防线");
            av_list.Add("AHPROCMONSERVER.exe", "安天防线");
            av_list.Add("AIRDEFENSE.exe", "AirDefense");
            av_list.Add("ALERTSVC.exe", "Norton AntiVirus");
            av_list.Add("AVIRA.exe", "小红伞杀毒");
            av_list.Add("AMON.exe", "Tiny Personal Firewall");
            av_list.Add("AVZ.exe", "AVZ");
            av_list.Add("ANTIVIR.exe", "已知杀软进程名称暂未收录");
            av_list.Add("APVXDWIN.exe", "熊猫卫士");
            av_list.Add("ASHMAISV.exe", "Alwil");
            av_list.Add("ASHSERV.exe", "Avast Anti-virus");
            av_list.Add("ASHSIMPL.exe", "AVAST!VirusCleaner");
            av_list.Add("ASHWEBSV.exe", "Avast");
            av_list.Add("ASWUPDSV.exe", "Avast");
            av_list.Add("ASWSCAN.exe", "Avast");
            av_list.Add("AVCIMAN.exe", "熊猫卫士");
            av_list.Add("AVCONSOL.exe", "McAfee");
            av_list.Add("AVENGINE.exe", "熊猫卫士");
            av_list.Add("AVESVC.exe", "Avira AntiVir Security Service");
            av_list.Add("AVEVL32.exe", "已知杀软进程名称暂未收录");
            av_list.Add("AVGAM.exe", "AVG");
            av_list.Add("AVGCC.exe", "AVG");
            av_list.Add("AVGCHSVX.exe", "AVG");
            av_list.Add("AVGCSRVX", "AVG");
            av_list.Add("AVGNSX.exe", "AVG");
            av_list.Add("AVGCC32.exe", "AVG");
            av_list.Add("AVGCTRL.exe", "AVG");
            av_list.Add("AVGEMC.exe", "AVG");
            av_list.Add("AVGFWSRV.exe", "AVG");
            av_list.Add("AVGNTMGR.exe", "AVG");
            av_list.Add("AVGSERV.exe", "AVG");
            av_list.Add("AVGTRAY.exe", "AVG");
            av_list.Add("AVGUPSVC.exe", "AVG");
            av_list.Add("AVINITNT.exe", "Command AntiVirus for NT Server");
            av_list.Add("AVPCC.exe", "Kaspersky");
            av_list.Add("AVSERVER.exe", "Kerio MailServer");
            av_list.Add("AVSCHED32.exe", "H+BEDV");
            av_list.Add("AVSYNMGR.exe", "McAfee");
            av_list.Add("AVWUPSRV.exe", "H+BEDV");
            av_list.Add("BDSWITCH.exe", "BitDefender Module");
            av_list.Add("BLACKD.exe", "BlackICE");
            av_list.Add("CCEVTMGR.exe", "Symantec");
            av_list.Add("CFP.exe", "COMODO");
            av_list.Add("CLAMWIN.exe", "ClamWin Portable");
            av_list.Add("CUREIT.exe", "DrWeb CureIT");
            av_list.Add("DEFWATCH.exe", "Norton Antivirus");
            av_list.Add("DRWADINS.exe", "Dr.Web");
            av_list.Add("DRWEB.exe", "Dr.Web");
            av_list.Add("DEFENDERDAEMON.exe", "ShadowDefender");
            av_list.Add("EWIDOCTRL.exe", "Ewido Security Suite");
            av_list.Add("EZANTIVIRUSREGISTRATIONCHECK.exe", "e-Trust Antivirus");
            av_list.Add("FIREWALL.exe", "AshampooSoftware");
            av_list.Add("FPROTTRAY.exe", "F-PROT Antivirus");
            av_list.Add("FPWIN.exe", "Verizon");
            av_list.Add("FRESHCLAM.exe", "ClamAV");
            av_list.Add("FSAV32.exe", "F-Secure");
            av_list.Add("FSBWSYS.exe", "F-secure");
            av_list.Add("FSDFWD.exe", "F-Secure");
            av_list.Add("FSGK32.exe", "F-Secure");
            av_list.Add("FSGK32ST.exe", "F-Secure");
            av_list.Add("FSMA32.exe", "F-Secure");
            av_list.Add("FSMB32.exe", "F-Secure");
            av_list.Add("FSSM32.exe", "F-Secure");
            av_list.Add("GUARDGUI.exe", "网游保镖");
            av_list.Add("GUARDNT.exe", "IKARUS");
            av_list.Add("IAMAPP.exe", "Symantec");
            av_list.Add("INOCIT.exe", "eTrust");
            av_list.Add("INORPC.exe", "eTrust");
            av_list.Add("INORT.exe", "eTrust");
            av_list.Add("INOTASK.exe", "eTrust");
            av_list.Add("INOUPTNG.exe", "eTrust");
            av_list.Add("ISAFE.exe", "eTrust");
            av_list.Add("KAV.exe", "Kaspersky");
            av_list.Add("KAVMM.exe", "Kaspersky");
            av_list.Add("KAVPF.exe", "Kaspersky");
            av_list.Add("KAVPFW.exe", "Kaspersky");
            av_list.Add("KAVSTART.exe", "Kaspersky");
            av_list.Add("KAVSVC.exe", "Kaspersky");
            av_list.Add("KAVSVCUI.exe", "Kaspersky");
            av_list.Add("KMAILMON.exe", "金山毒霸");
            av_list.Add("MCAGENT.exe", "McAfee");
            av_list.Add("MCMNHDLR.exe", "McAfee");
            av_list.Add("MCREGWIZ.exe", "McAfee");
            av_list.Add("MCUPDATE.exe", "McAfee");
            av_list.Add("MCVSSHLD.exe", "McAfee");
            av_list.Add("MINILOG.exe", "Zone Alarm");
            av_list.Add("MYAGTSVC.exe", "McAfee");
            av_list.Add("MYAGTTRY.exe", "McAfee");
            av_list.Add("NAVAPSVC.exe", "Norton");
            av_list.Add("NAVAPW32.exe", "Norton");
            av_list.Add("NAVLU32.exe", "Norton");
            av_list.Add("NAVW32.exe", "Norton Antivirus");
            av_list.Add("NEOWATCHLOG.exe", "NeoWatch");
            av_list.Add("NEOWATCHTRAY.exe", "NeoWatch");
            av_list.Add("NISSERV.exe", "Norton");
            av_list.Add("NISUM.exe", "Norton");
            av_list.Add("NMAIN.exe", "Norton");
            av_list.Add("NOD32.exe", "ESET NOD32");
            av_list.Add("NPFMSG.exe", "Norman个人防火墙");
            av_list.Add("NPROTECT.exe", "Symantec");
            av_list.Add("NSMDTR.exe", "Norton");
            av_list.Add("NTRTSCAN.exe", "趋势科技");
            av_list.Add("OFCPFWSVC.exe", "OfficeScanNT");
            av_list.Add("ONLINENT.exe", "已知杀软进程名称暂未收录");
            av_list.Add("OP_MON.exe", " OutpostFirewall");
            av_list.Add("PAVFIRES.exe", "熊猫卫士");
            av_list.Add("PAVFNSVR.exe", "熊猫卫士");
            av_list.Add("PAVKRE.exe", "熊猫卫士");
            av_list.Add("PAVPROT.exe", "熊猫卫士");
            av_list.Add("PAVPROXY.exe", "熊猫卫士");
            av_list.Add("PAVPRSRV.exe", "熊猫卫士");
            av_list.Add("PAVSRV51.exe", "熊猫卫士");
            av_list.Add("PAVSS.exe", "熊猫卫士");
            av_list.Add("PCCGUIDE.exe", "PC-cillin");
            av_list.Add("PCCIOMON.exe", "PC-cillin");
            av_list.Add("PCCNTMON.exe", "PC-cillin");
            av_list.Add("PCCPFW.exe", "趋势科技");
            av_list.Add("PCCTLCOM.exe", "趋势科技");
            av_list.Add("PCTAV.exe", "PC Tools AntiVirus");
            av_list.Add("PERSFW.exe", "Tiny Personal Firewall");
            av_list.Add("PERVAC.exe", "已知杀软进程名称暂未收录");
            av_list.Add("PESTPATROL.exe", "Ikarus");
            av_list.Add("PREVSRV.exe", "熊猫卫士");
            av_list.Add("RTVSCN95.exe", "Real-time Virus Scanner");
            av_list.Add("SAVADMINSERVICE.exe", "SAV");
            av_list.Add("SAVMAIN.exe", "SAV");
            av_list.Add("SAVSCAN.exe", "SAV");
            av_list.Add("SDHELP.exe", "Spyware Doctor");
            av_list.Add("SHSTAT.exe", "McAfee");
            av_list.Add("SPBBCSVC.exe", "Symantec");
            av_list.Add("SPIDERCPL.exe", "Dr.Web");
            av_list.Add("SPIDERML.exe", "Dr.Web");
            av_list.Add("SPIDERUI.exe", "Dr.Web");
            av_list.Add("SPYBOTSD.exe", "Spybot ");
            av_list.Add("SWAGENT.exe", "SonicWALL");
            av_list.Add("SWDOCTOR.exe", "SonicWALL");
            av_list.Add("SWNETSUP.exe", "Sophos");
            av_list.Add("SYMLCSVC.exe", "Symantec");
            av_list.Add("SYMPROXYSVC.exe", "Symantec");
            av_list.Add("SYMSPORT.exe", "Sysmantec");
            av_list.Add("SYMWSC.exe", "Sysmantec");
            av_list.Add("SYNMGR.exe", "Sysmantec");
            av_list.Add("TMLISTEN.exe", "趋势科技");
            av_list.Add("TMNTSRV.exe", "趋势科技");
            av_list.Add("TMPROXY.exe", "趋势科技");
            av_list.Add("TNBUTIL.exe", "Anti-Virus");
            av_list.Add("VBA32ECM.exe", "已知杀软进程名称暂未收录");
            av_list.Add("VBA32IFS.exe", "已知杀软进程名称暂未收录");
            av_list.Add("VBA32PP3.exe", "已知杀软进程名称暂未收录");
            av_list.Add("VCRMON.exe", "VirusChaser");
            av_list.Add("VRMONNT.exe", "HAURI");
            av_list.Add("VRMONSVC.exe", "HAURI");
            av_list.Add("VSHWIN32.exe", "McAfee");
            av_list.Add("VSSTAT.exe", "McAfee");
            av_list.Add("XCOMMSVR.exe", "BitDefender");
            av_list.Add("ZONEALARM.exe", "Zone Alarm");
            av_list.Add("360rp.exe", "360杀毒");
            av_list.Add("afwServ.exe", " Avast Antivirus");
            av_list.Add("safeboxTray.exe", "360杀毒");
            av_list.Add("360safebox.exe", "360杀毒");
            av_list.Add("QQPCTray.exe", "QQ电脑管家");
            av_list.Add("KSafeTray.exe", "金山毒霸");
            av_list.Add("KSafeSvc.exe", "金山毒霸");
            av_list.Add("KWatch.exe", "金山毒霸");
            av_list.Add("gov_defence_service.exe", "云锁");
            av_list.Add("gov_defence_daemon.exe", "云锁");
            av_list.Add("smartscreen.exe", "Windows Defender");
            av_list.Add("navicat.exe", "数据库管理");
            av_list.Add("AliSecGuard.exe", "阿里云盾");
            av_list.Add("AliYunDunUpdate.exe", "阿里云盾");
            av_list.Add("AliYunDun.exe", "阿里云盾");
            av_list.Add("CmsGoAgent.windows-amd64.", "阿里云监控");
            av_list.Add("HipsTray.exe", "火绒");
            av_list.Add("HipsDaemon.exe", "火绒");
            av_list.Add("AvEmUpdate.exe", "AvastAnti-virus");
            av_list.Add("macompatsvc.exe", "McAfee");
            av_list.Add("mcamnsvc.exe", "McAfee");
            av_list.Add("masvc.exe", "McAfee");
            av_list.Add("mfemms.exe", "McAfee");
            av_list.Add("mctary.exe", "McAfee");
            av_list.Add("mcshield.exe", "McAfee");
            av_list.Add("mfewc.exe", "McAfee");
            av_list.Add("mfewch.exe", "McAfee");
            av_list.Add("mfefw.exe", "McAfee");
            av_list.Add("mfefire.exe", "McAfee");
            av_list.Add("mfetp.exe", "McAfee");
            av_list.Add("mfecanary.exe", "McAfee");
            av_list.Add("mfeconsole.exe", "McAfee");
            av_list.Add("mfeesp.exe", "McAfee");
            av_list.Add("fcag.exe", "McAfee");
            av_list.Add("fcags.exe", "McAfee");
            av_list.Add("fcagswd.exe", "McAfee");
            av_list.Add("fcagate.exe", "McAfee");
            av_list.Add("360EntClient.exe", "天擎EDRAgent");
            av_list.Add("QaxEntClient.exe", "天擎EDRAgent");
            av_list.Add("QAXTray.exe", "天擎EDRAgent");
            av_list.Add("edr_sec_plan.exe", "深信服EDRAgent");
            av_list.Add("edr_monitor.exe", "深信服EDRAgent");
            av_list.Add("edr_agent.exe", "深信服EDRAgent");
            av_list.Add("ESCCControl.exe", "启明星辰天珣EDRAgent");
            av_list.Add("ESCC.exe", "启明星辰天珣EDRAgent");
            av_list.Add("ESAV.exe", "启明星辰天珣EDRAgent");
            av_list.Add("ESCCIndex.exe", "启明星辰天珣EDRAgent");
            av_list.Add("wdswfsafe.exe", "360杀毒-网盾");
            av_list.Add("TopsecMain.exe", "天融信终端防御");
            av_list.Add("TopsecTray.exe", "天融信终端防御");
            av_list.Add("YDLive.exe", "腾讯云-云镜");
            av_list.Add("YDService.exe", "腾讯云-云镜");
            av_list.Add("TitanAgent.exe", "天眼云镜");
            av_list.Add("TitanMonitor.exe", "天眼云镜");
            av_list.Add("gse_win_daemon.exe", "蓝鲸Agent");
            av_list.Add("gse_win_agent.exe", "蓝鲸Agent");
            av_list.Add("QHActiveDefense.exe", "360TotalSecurity(360国际版)");
            av_list.Add("QHWatchdog.exe", "360TotalSecurity(360国际版)");
            av_list.Add("QHSafeTray.exe", "360TotalSecurity(360国际版)");
            av_list.Add("QHSafeMain.exe", "360TotalSecurity(360国际版)");
            av_list.Add("JingYunMonSvr.exe", "景云防病毒");
            av_list.Add("JingyunSdMainSvr.exe", "景云防病毒");
            av_list.Add("JingyunSdSvr.exe", "景云防病毒");
            av_list.Add("JingyunSdTray.exe", "景云防病毒");
            av_list.Add("LenovoPcManager.exe", "联想电脑管家");
            av_list.Add("LenovoTray.exe", "联想电脑管家防护中心");
            av_list.Add("MSPCManager.exe", "微软电脑管家-公测版");
            av_list.Add("vkise.exe", "ComodoAnti-virus网页保护程序");
            av_list.Add("wsc_proxy.exe", "Avast");

            // 读取进程
            Cmd c = new Cmd();
            Console.WriteLine("正在获取杀软信息请稍等。。。\n\r");
            string resultStr = c.RunCmd("tasklist /SVC /FO LIST");
            List<string> resultStrlist = new List<string>();
            resultStrlist = resultStr.Split('\n').ToList();

            // 提取进程中的杀软
            List<string> getav_list = new List<string>();
            foreach (var i in resultStrlist)
            {
                if (i.IndexOf("映像名称") > -1)
                {
                    List<string> ilist = new List<string>();
                    ilist = i.Split(':').ToList();
                    //Console.WriteLine(ilist[1].Trim());
                    foreach (KeyValuePair<string, string> kvp in av_list)
                    {
                        if (kvp.Key == ilist[1].Trim())
                        {
                            getav_list.Add(kvp.Key + ": " + kvp.Value);
                            //Console.WriteLine(kvp.Key + ": " + kvp.Value);
                        }
                    }
                }
            }
            if (getav_list.Count != 0)
            {
                Console.WriteLine("存在杀软信息如下：");
                foreach (var j in getav_list)
                {
                    Console.WriteLine(j);
                }
            }
            else
            {
                Console.WriteLine("暂未发现杀软");
            }
        }
    }

    /// <summary>
    /// Cmd 的摘要说明。
    /// </summary>
    public class Cmd
    {
        private Process proc = null;
        /// <summary>
        /// 构造方法
        /// </summary>
        public Cmd()
        {
            proc = new Process();
        }
        /// <summary>
        /// 执行CMD语句
        /// </summary>
        /// <param name="cmd">要执行的CMD命令</param>
        public string RunCmd(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");
            string outStr = proc.StandardOutput.ReadToEnd();
            proc.Close();
            return outStr;
        }
    }
}
