# Xamarin.Auth iOS10 Crash

https://github.com/xamarin/Xamarin.Auth/issues/384

## Steps to reproduce:
- Open the MainPage.xaml.cs
- Set the value for clientId, clientSecret and redirectUrl
- Run the app

It crashs on iOS 10 but works fine on iOS 12, the crash doesn't happen on simulator.

## Crash log:

Incident Identifier: ED4DD2FB-625A-46F0-A539-04AEE0BCE727
CrashReporter Key:   322eeff13d838cd16a2291ec25ddc170118cc929
Hardware Model:      iPhone9,2
Process:             XamarinAuthIssue.iOS [787]
Path:                /private/var/containers/Bundle/Application/95003DE5-58C5-4FBC-B32B-12E8C548C406/XamarinAuthIssue.iOS.app/XamarinAuthIssue.iOS
Identifier:          santana.garcia.elton.XamarinAuthIssue
Version:             1.0 (1.0)
Code Type:           ARM-64 (Native)
Role:                Foreground
Parent Process:      launchd [1]
Coalition:           santana.garcia.elton.XamarinAuthIssue [809]


Date/Time:           2019-05-25 19:49:23.0535 +0800
Launch Time:         2019-05-25 19:49:16.8672 +0800
OS Version:          iPhone OS 10.2 (14C92)
Report Version:      104

Exception Type:  EXC_CRASH (SIGILL)
Exception Codes: 0x0000000000000000, 0x0000000000000000
Exception Note:  EXC_CORPSE_NOTIFY
Termination Signal: Illegal instruction: 4
Termination Reason: Namespace SIGNAL, Code 0x4
Terminating Process: XamarinAuthIssue.iOS [787]
Triggered by Thread:  0

Filtered syslog:
None found

Thread 0 name:  tid_403  Dispatch queue: com.apple.main-thread
Thread 0 Crashed:
0   libsystem_kernel.dylib        	0x00000001908b9188 mach_msg_trap + 8
1   libsystem_kernel.dylib        	0x00000001908b8ff8 mach_msg + 72
2   CoreFoundation                	0x00000001918b65d0 __CFRunLoopServiceMachPort + 192
3   CoreFoundation                	0x00000001918b41ec __CFRunLoopRun + 1132
4   CoreFoundation                	0x00000001917e22b8 CFRunLoopRunSpecific + 444
5   GraphicsServices              	0x0000000193296198 GSEventRunModal + 180
6   UIKit                         	0x00000001978297fc -[UIApplication _run] + 684
7   UIKit                         	0x0000000197824534 UIApplicationMain + 208
8   XamarinAuthIssue.iOS          	0x0000000100552ee4 wrapper_managed_to_native_UIKit_UIApplication_UIApplicationMain_int_string___intptr_intptr + 324
9   XamarinAuthIssue.iOS          	0x00000001004d0bfc UIKit_UIApplication_Main_string___intptr_intptr + 4164604 (UIApplication.cs:79)
10  XamarinAuthIssue.iOS          	0x00000001004d0bbc UIKit_UIApplication_Main_string___string_string + 4164540 (UIApplication.cs:64)
11  XamarinAuthIssue.iOS          	0x000000010010d7b0 XamarinAuthIssue_iOS_Application_Main_string__ + 219056 (Main.cs:17)
12  XamarinAuthIssue.iOS          	0x0000000100426068 wrapper_runtime_invoke_object_runtime_invoke_dynamic_intptr_intptr_intptr_intptr + 248
13  XamarinAuthIssue.iOS          	0x00000001014bc714 mono_jit_runtime_invoke + 20858644 (mini-runtime.c:3120)
14  XamarinAuthIssue.iOS          	0x0000000101547a88 mono_runtime_invoke_checked + 21428872 (object.c:2960)
15  XamarinAuthIssue.iOS          	0x000000010154ce50 mono_runtime_exec_main_checked + 21450320 (object.c:0)
16  XamarinAuthIssue.iOS          	0x00000001014a2068 mono_jit_exec + 20750440 (driver.g.c:1236)
17  XamarinAuthIssue.iOS          	0x00000001015f6bbc xamarin_main + 22145980 (monotouch-main.m:484)
18  XamarinAuthIssue.iOS          	0x000000010010d6a8 main + 218792 (main.m:83)
19  libdyld.dylib                 	0x00000001907c55b8 start + 4

Thread 1:
0   libsystem_pthread.dylib       	0x000000019099ad88 start_wqthread + 0

Thread 2:
0   libsystem_pthread.dylib       	0x000000019099ad88 start_wqthread + 0

Thread 3:
0   libsystem_pthread.dylib       	0x000000019099ad88 start_wqthread + 0

Thread 4:
0   libsystem_kernel.dylib        	0x00000001908d7314 __semwait_signal + 8
1   libsystem_c.dylib             	0x00000001907f525c nanosleep + 212
2   libc++.1.dylib                	0x0000000190305994 std::__1::this_thread::sleep_for+ 293268 (std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000000000l> > const&) + 80
3   JavaScriptCore                	0x00000001960e63ec void std::__1::this_thread::sleep_for<long long, std::__1::ratio<1l, 1000l> >+ 9278444 (std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000l> > const&) + 76
4   JavaScriptCore                	0x00000001960e5438 bmalloc::waitUntilFalse+ 9274424 (std::__1::unique_lock<bmalloc::StaticMutex>&, std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000l> >, bool&) + 128
5   JavaScriptCore                	0x00000001960e5274 bmalloc::Heap::scavenge+ 9273972 (std::__1::unique_lock<bmalloc::StaticMutex>&, std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000l> >) + 60
6   JavaScriptCore                	0x00000001960e5114 bmalloc::Heap::concurrentScavenge+ 9273620 () + 80
7   JavaScriptCore                	0x00000001960e64d8 bmalloc::AsyncTask<bmalloc::Heap, void (bmalloc::Heap::*)()>::threadRunLoop+ 9278680 () + 92
8   JavaScriptCore                	0x00000001960e6404 std::__1::__shared_ptr_emplace<std::__1::mutex, std::__1::allocator<std::__1::mutex> >::~__shared_ptr_emplace+ 9278468 () + 0
9   JavaScriptCore                	0x00000001960e66b4 void* std::__1::__thread_proxy<std::__1::tuple<void (*)(bmalloc::AsyncTask<bmalloc::Heap, void (bmalloc::Heap::*)()>*), bmalloc::AsyncTask<bmalloc::Heap, void (bmalloc::Heap::*)()>*> >+ 9279156 (void*) + 92
10  libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
11  libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
12  libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 5 name:  WebThread
Thread 5:
0   JavaScriptCore                	0x0000000195f322d8 llint_entry + 15848

Thread 6 name:  SGen worker
Thread 6:
0   libsystem_kernel.dylib        	0x00000001908d6e1c __psynch_cvwait + 8
1   libsystem_pthread.dylib       	0x000000019099c9c0 _pthread_cond_wait + 640
2   XamarinAuthIssue.iOS          	0x00000001015c4a64 thread_func + 21940836 (mono-os-mutex.h:174)
3   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
4   libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
5   libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 7 name:  Finalizer
Thread 7:
0   libsystem_kernel.dylib        	0x00000001908b91c4 semaphore_wait_trap + 8
1   XamarinAuthIssue.iOS          	0x000000010150bce0 finalizer_thread + 21183712 (mono-os-semaphore.h:91)
2   XamarinAuthIssue.iOS          	0x0000000101575ce0 start_wrapper_internal + 21617888 (threads.c:1155)
3   XamarinAuthIssue.iOS          	0x0000000101575b64 start_wrapper + 21617508 (threads.c:1217)
4   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
5   libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
6   libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 8 name:  com.apple.uikit.eventfetch-thread
Thread 8:
0   libsystem_kernel.dylib        	0x00000001908b9188 mach_msg_trap + 8
1   libsystem_kernel.dylib        	0x00000001908b8ff8 mach_msg + 72
2   CoreFoundation                	0x00000001918b65d0 __CFRunLoopServiceMachPort + 192
3   CoreFoundation                	0x00000001918b41ec __CFRunLoopRun + 1132
4   CoreFoundation                	0x00000001917e22b8 CFRunLoopRunSpecific + 444
5   Foundation                    	0x000000019231f26c -[NSRunLoop+ 49772 (NSRunLoop) runMode:beforeDate:] + 304
6   Foundation                    	0x000000019233fdd0 -[NSRunLoop+ 183760 (NSRunLoop) runUntilDate:] + 96
7   UIKit                         	0x000000019819dc38 -[UIEventFetcher threadMain] + 136
8   Foundation                    	0x000000019241ce68 __NSThread__start__ + 1024
9   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
10  libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
11  libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 9:
0   libsystem_pthread.dylib       	0x000000019099ad88 start_wqthread + 0

Thread 10 name:  com.apple.NSURLConnectionLoader
Thread 10:
0   libsystem_kernel.dylib        	0x00000001908b9188 mach_msg_trap + 8
1   libsystem_kernel.dylib        	0x00000001908b8ff8 mach_msg + 72
2   CoreFoundation                	0x00000001918b65d0 __CFRunLoopServiceMachPort + 192
3   CoreFoundation                	0x00000001918b41ec __CFRunLoopRun + 1132
4   CoreFoundation                	0x00000001917e22b8 CFRunLoopRunSpecific + 444
5   CFNetwork                     	0x0000000191fe78f0 +[NSURLConnection+ 915696 (Loader) _resourceLoadLoop:] + 336
6   Foundation                    	0x000000019241ce68 __NSThread__start__ + 1024
7   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
8   libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
9   libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 11 name:  JIT Worklist Worker Thread
Thread 11:
0   libsystem_kernel.dylib        	0x00000001908d6e1c __psynch_cvwait + 8
1   libsystem_pthread.dylib       	0x000000019099c9c0 _pthread_cond_wait + 640
2   libc++.1.dylib                	0x00000001902c53ec std::__1::condition_variable::wait+ 29676 (std::__1::unique_lock<std::__1::mutex>&) + 56
3   JavaScriptCore                	0x00000001960ced44 WTF::ParkingLot::parkConditionallyImpl(void const*, WTF::ScopedLambda<bool ()> const&, WTF::ScopedLambda<void + 9182532 ()> const&, std::__1::chrono::time_point<std::__1::chrono::steady_clock, std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000000000l> > >) + 2132
4   JavaScriptCore                	0x0000000195ea6a38 JSC::JITWorklist::runThread+ 6920760 () + 192
5   JavaScriptCore                	0x0000000195ea6e88 WTF::Vector<WTF::RefPtr<JSC::JITWorklist::Plan>, 32ul, WTF::CrashOnOverflow, 16ul>::expandCapacity+ 6921864 (unsigned long, WTF::RefPtr<JSC::JITWorklist::Plan>*) + 0
6   JavaScriptCore                	0x000000019581709c WTF::threadEntryPoint+ 41116 (void*) + 212
7   JavaScriptCore                	0x0000000195816fac WTF::wtfThreadEntryPoint+ 40876 (void*) + 24
8   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
9   libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
10  libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 12 name:  WTF Parallel Helper Thread
Thread 12:
0   libsystem_kernel.dylib        	0x00000001908d6e1c __psynch_cvwait + 8
1   libsystem_pthread.dylib       	0x000000019099c9c0 _pthread_cond_wait + 640
2   libc++.1.dylib                	0x00000001902c53ec std::__1::condition_variable::wait+ 29676 (std::__1::unique_lock<std::__1::mutex>&) + 56
3   JavaScriptCore                	0x00000001960ced44 WTF::ParkingLot::parkConditionallyImpl(void const*, WTF::ScopedLambda<bool ()> const&, WTF::ScopedLambda<void + 9182532 ()> const&, std::__1::chrono::time_point<std::__1::chrono::steady_clock, std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000000000l> > >) + 2132
4   JavaScriptCore                	0x00000001960ce2c8 WTF::ParallelHelperPool::waitForClientWithTask+ 9179848 (WTF::Locker<WTF::LockBase> const&) + 288
5   JavaScriptCore                	0x00000001960ce068 WTF::ParallelHelperPool::helperThreadBody+ 9179240 () + 76
6   JavaScriptCore                	0x000000019581709c WTF::threadEntryPoint+ 41116 (void*) + 212
7   JavaScriptCore                	0x0000000195816fac WTF::wtfThreadEntryPoint+ 40876 (void*) + 24
8   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
9   libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
10  libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 13 name:  WebCore: LocalStorage
Thread 13:
0   libsystem_kernel.dylib        	0x00000001908d6e1c __psynch_cvwait + 8
1   libsystem_pthread.dylib       	0x000000019099c9c0 _pthread_cond_wait + 640
2   libc++.1.dylib                	0x00000001902c53ec std::__1::condition_variable::wait+ 29676 (std::__1::unique_lock<std::__1::mutex>&) + 56
3   JavaScriptCore                	0x00000001960ced44 WTF::ParkingLot::parkConditionallyImpl(void const*, WTF::ScopedLambda<bool ()> const&, WTF::ScopedLambda<void + 9182532 ()> const&, std::__1::chrono::time_point<std::__1::chrono::steady_clock, std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000000000l> > >) + 2132
4   WebKitLegacy                  	0x00000001974cee8c bool WTF::ConditionBase::waitForSecondsImpl<WTF::Lock>+ 192140 (WTF::Lock&, double) + 128
5   WebKitLegacy                  	0x00000001974ceca4 std::__1::unique_ptr<WTF::Function<void ()>, std::__1::default_delete<WTF::Function<void ()> > > WTF::MessageQueue<WTF::Function<void ()> >::waitForMessageFilteredWithTimeout<WTF::MessageQueue<WTF::Function<void ()> >::waitForMessage()::'lambda'(WTF::Function<void ()> const&)>(WTF::MessageQueueWaitResult&, WTF::MessageQueue<WTF::Function<void ()> >::waitForMessage()::'lambda'(WTF::Function<void + 191652 ()> const&)&&, double) + 124
6   WebKitLegacy                  	0x00000001974ce2cc WebCore::StorageThread::threadEntryPoint+ 189132 () + 68
7   JavaScriptCore                	0x000000019581709c WTF::threadEntryPoint+ 41116 (void*) + 212
8   JavaScriptCore                	0x0000000195816fac WTF::wtfThreadEntryPoint+ 40876 (void*) + 24
9   libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
10  libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
11  libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 14 name:  IndexedDatabase Server
Thread 14:
0   libsystem_kernel.dylib        	0x00000001908d6e1c __psynch_cvwait + 8
1   libsystem_pthread.dylib       	0x000000019099c9c0 _pthread_cond_wait + 640
2   libc++.1.dylib                	0x00000001902c53ec std::__1::condition_variable::wait+ 29676 (std::__1::unique_lock<std::__1::mutex>&) + 56
3   JavaScriptCore                	0x00000001960ced44 WTF::ParkingLot::parkConditionallyImpl(void const*, WTF::ScopedLambda<bool ()> const&, WTF::ScopedLambda<void + 9182532 ()> const&, std::__1::chrono::time_point<std::__1::chrono::steady_clock, std::__1::chrono::duration<long long, std::__1::ratio<1l, 1000000000l> > >) + 2132
4   WebCore                       	0x0000000196592b0c bool WTF::ConditionBase::waitForSecondsImpl<WTF::Lock>+ 2165516 (WTF::Lock&, double) + 128
5   WebCore                       	0x00000001969cf4bc WTF::CrossThreadQueue<WTF::CrossThreadTask>::waitForMessage+ 6608060 () + 112
6   WebCore                       	0x00000001969cf43c WebCore::IDBServer::IDBServer::databaseRunLoop+ 6607932 () + 152
7   WebCore                       	0x00000001969cd6b8 WebCore::IDBServer::IDBServer::registerConnection+ 6600376 (WebCore::IDBServer::IDBConnectionToClient&) + 0
8   JavaScriptCore                	0x000000019581709c WTF::threadEntryPoint+ 41116 (void*) + 212
9   JavaScriptCore                	0x0000000195816fac WTF::wtfThreadEntryPoint+ 40876 (void*) + 24
10  libsystem_pthread.dylib       	0x000000019099d850 _pthread_body + 240
11  libsystem_pthread.dylib       	0x000000019099d760 _pthread_body + 0
12  libsystem_pthread.dylib       	0x000000019099ad94 thread_start + 4

Thread 0 crashed with ARM Thread State (64-bit):
    x0: 0x0000000010004005   x1: 0x0000000007000806   x2: 0x0000000000000000   x3: 0x0000000000000c00
    x4: 0x0000000000001903   x5: 0x00000000ffffffff   x6: 0x0000000000000000   x7: 0x0000000000002701
    x8: 0x00000000fffffbbf   x9: 0x0000000007000000  x10: 0x0000000007000100  x11: 0x000000000000005a
   x12: 0x00024e0000024f03  x13: 0x0000000000000000  x14: 0x00024f0000024f00  x15: 0x0000000000000000
   x16: 0xffffffffffffffe1  x17: 0x0000000191806a34  x18: 0x0000000000000000  x19: 0x0000000000000000
   x20: 0x00000000ffffffff  x21: 0x0000000000001903  x22: 0x0000000000000c00  x23: 0x000000016fd25e58
   x24: 0x0000000007000806  x25: 0x0000000000000000  x26: 0x0000000007000806  x27: 0x0000000000000c00
   x28: 0x0000000000000001   fp: 0x000000016fd25d50   lr: 0x00000001908b8ff8
    sp: 0x000000016fd25d00   pc: 0x00000001908b9188 cpsr: 0x60000000

Binary Images:
0x1000d8000 - 0x1016bbfff XamarinAuthIssue.iOS arm64  <19fe22526c713376aca39680929a6469> /var/containers/Bundle/Application/95003DE5-58C5-4FBC-B32B-12E8C548C406/XamarinAuthIssue.iOS.app/XamarinAuthIssue.iOS
0x101910000 - 0x10193ffff dyld arm64  <f54ed85a94253887886a8028e20ed8ba> /usr/lib/dyld
0x1902bc000 - 0x1902bdfff libSystem.B.dylib arm64  <6c1de96c8fe5363cab2ef76f891c6e22> /usr/lib/libSystem.B.dylib
0x1902be000 - 0x190313fff libc++.1.dylib arm64  <b2db8b1d09283b7bafe1b2933adc5dfd> /usr/lib/libc++.1.dylib
0x190314000 - 0x190334fff libc++abi.dylib arm64  <e3419bbaface31b5970c6c8d430be26d> /usr/lib/libc++abi.dylib
0x190338000 - 0x190711fff libobjc.A.dylib arm64  <538f809dcd7c35ceb59d99802248f045> /usr/lib/libobjc.A.dylib
0x190712000 - 0x190716fff libcache.dylib arm64  <f09cab6893c631218f817e61b3d77fcb> /usr/lib/system/libcache.dylib
0x190717000 - 0x190722fff libcommonCrypto.dylib arm64  <e071643355cd3f67bae19045c7f9f340> /usr/lib/system/libcommonCrypto.dylib
0x190723000 - 0x190726fff libcompiler_rt.dylib arm64  <8209cb28df5d3b48894899019fcbb344> /usr/lib/system/libcompiler_rt.dylib
0x190727000 - 0x19072efff libcopyfile.dylib arm64  <567f33ef4d8f3e48a5afac933ccd389f> /usr/lib/system/libcopyfile.dylib
0x19072f000 - 0x190790fff libcorecrypto.dylib arm64  <056a6c201d3d3696b59f0b264ba9b972> /usr/lib/system/libcorecrypto.dylib
0x190791000 - 0x1907c0fff libdispatch.dylib arm64  <fb1d0baf642337d1bea0af309586df97> /usr/lib/system/libdispatch.dylib
0x1907c1000 - 0x1907c5fff libdyld.dylib arm64  <6ebb575f616935cbbef02f2c031490d1> /usr/lib/system/libdyld.dylib
0x1907c6000 - 0x1907c6fff liblaunch.dylib arm64  <ceb57f62c49e38d8a8d33309db668bd3> /usr/lib/system/liblaunch.dylib
0x1907c7000 - 0x1907ccfff libmacho.dylib arm64  <20627f9f062c3ee8873e3ab3bc3fda8c> /usr/lib/system/libmacho.dylib
0x1907cd000 - 0x1907cefff libremovefile.dylib arm64  <43110ffd953537e28981c6dead2c0b1f> /usr/lib/system/libremovefile.dylib
0x1907cf000 - 0x1907e6fff libsystem_asl.dylib arm64  <e52a49b27e963d2bb90332a5b0895f8d> /usr/lib/system/libsystem_asl.dylib
0x1907e7000 - 0x1907e7fff libsystem_blocks.dylib arm64  <480fe954b3f63f16af8acfd6dc34e2da> /usr/lib/system/libsystem_blocks.dylib
0x1907e8000 - 0x190866fff libsystem_c.dylib arm64  <8a5a190d70563f3c8d4ce16cab74f599> /usr/lib/system/libsystem_c.dylib
0x190867000 - 0x19086bfff libsystem_configuration.dylib arm64  <7628c33e4c383a78b0e33cf403e6f019> /usr/lib/system/libsystem_configuration.dylib
0x19086c000 - 0x190871fff libsystem_containermanager.dylib arm64  <9de64e7545ab359fb9cefc695aa510f0> /usr/lib/system/libsystem_containermanager.dylib
0x190872000 - 0x190873fff libsystem_coreservices.dylib arm64  <e61211f8f4c9399595fbd921e8589a8b> /usr/lib/system/libsystem_coreservices.dylib
0x190874000 - 0x19088cfff libsystem_coretls.dylib arm64  <14fa1ba4b14b338181c2ef87b214695e> /usr/lib/system/libsystem_coretls.dylib
0x19088d000 - 0x190893fff libsystem_dnssd.dylib arm64  <7d745bdfb72e3119bad43c36f60a5a8a> /usr/lib/system/libsystem_dnssd.dylib
0x190894000 - 0x1908b7fff libsystem_info.dylib arm64  <6546bc8b4fa23df898bf2471e801d50b> /usr/lib/system/libsystem_info.dylib
0x1908b8000 - 0x1908dcfff libsystem_kernel.dylib arm64  <9ec307fcdd2f3f728f37ec6e0186df20> /usr/lib/system/libsystem_kernel.dylib
0x1908dd000 - 0x190909fff libsystem_m.dylib arm64  <ba786894a7213d37baa99aafc0ee5493> /usr/lib/system/libsystem_m.dylib
0x19090a000 - 0x190925fff libsystem_malloc.dylib arm64  <c57ecb4ada5c3930a580b3d07583058a> /usr/lib/system/libsystem_malloc.dylib
0x190926000 - 0x19097dfff libsystem_network.dylib arm64  <efa018a4cb4936e3b77b9194d390efc4> /usr/lib/system/libsystem_network.dylib
0x19097e000 - 0x190987fff libsystem_networkextension.dylib arm64  <34c2d9c2986f32dd996e4e439d94c9c5> /usr/lib/system/libsystem_networkextension.dylib
0x190988000 - 0x190992fff libsystem_notify.dylib arm64  <605beaf21db73cc3ae98a65e8c11f7d0> /usr/lib/system/libsystem_notify.dylib
0x190993000 - 0x190999fff libsystem_platform.dylib arm64  <518e18adfdfc316e9b4d519f6e4b6a47> /usr/lib/system/libsystem_platform.dylib
0x19099a000 - 0x1909a3fff libsystem_pthread.dylib arm64  <d8480fc3a35d3475b0d12553c761d8cb> /usr/lib/system/libsystem_pthread.dylib
0x1909a4000 - 0x1909a7fff libsystem_sandbox.dylib arm64  <89419e71367637d590768d37ca10d9a3> /usr/lib/system/libsystem_sandbox.dylib
0x1909a8000 - 0x1909affff libsystem_symptoms.dylib arm64  <832499573c1730b48f6ff8e7c06fae15> /usr/lib/system/libsystem_symptoms.dylib
0x1909b0000 - 0x1909cefff libsystem_trace.dylib arm64  <27778d14d3cb3239a6bb52a2461cd543> /usr/lib/system/libsystem_trace.dylib
0x1909cf000 - 0x1909d4fff libunwind.dylib arm64  <7a7545249f7d3a69a162acb73ec4f17a> /usr/lib/system/libunwind.dylib
0x1909d5000 - 0x1909d5fff libvminterpose.dylib arm64  <21d158555a6233b19c53df16cafb6974> /usr/lib/system/libvminterpose.dylib
0x1909d6000 - 0x1909fcfff libxpc.dylib arm64  <8f1330e254b83bd3a973af6933b91836> /usr/lib/system/libxpc.dylib
0x1909fd000 - 0x190c17fff libicucore.A.dylib arm64  <35fc5fa2aab8326897081ab8416c497c> /usr/lib/libicucore.A.dylib
0x190c18000 - 0x190c28fff libz.1.dylib arm64  <b3ab59ff330f3225a53b4e8e95440d77> /usr/lib/libz.1.dylib
0x1917d9000 - 0x191b5dfff CoreFoundation arm64  <dd9791d198ef32eea1335b8ebc9b3d55> /System/Library/Frameworks/CoreFoundation.framework/CoreFoundation
0x191b5e000 - 0x191b6efff libbsm.0.dylib arm64  <788093e9b6b738cea7045bfec4bef1d8> /usr/lib/libbsm.0.dylib
0x191b6f000 - 0x191b6ffff libenergytrace.dylib arm64  <3bcefd094fa83b26807a1c6c92933cd2> /usr/lib/libenergytrace.dylib
0x191b70000 - 0x191bebfff IOKit arm64  <e0a6f4f0810b3f75813eda2afebd591c> /System/Library/Frameworks/IOKit.framework/Versions/A/IOKit
0x191bec000 - 0x191c0cfff libMobileGestalt.dylib arm64  <1e9e78da74143c54bb1e50aa7e285a0f> /usr/lib/libMobileGestalt.dylib
0x191c0d000 - 0x191cf7fff libxml2.2.dylib arm64  <b3fc55542fe33491877c661cf410b164> /usr/lib/libxml2.2.dylib
0x191cf8000 - 0x191d86fff Security arm64  <88e5d6eb0de13ff6b7904f1b0e43a88e> /System/Library/Frameworks/Security.framework/Security
0x191d87000 - 0x191df1fff SystemConfiguration arm64  <d907035d1ff936e5986035f50a77f5d3> /System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration
0x191df2000 - 0x191f07fff libsqlite3.dylib arm64  <87863a80836a3d659e5485f5029c3ed4> /usr/lib/libsqlite3.dylib
0x191f08000 - 0x1922a1fff CFNetwork arm64  <d63319a4fe2738dfb695ceb729f9b972> /System/Library/Frameworks/CFNetwork.framework/CFNetwork
0x1922a2000 - 0x1922b2fff libbz2.1.0.dylib arm64  <0d14fa7337f43079bad2a4cfc6d66b70> /usr/lib/libbz2.1.0.dylib
0x1922b3000 - 0x1922cbfff liblzma.5.dylib arm64  <b90cea0595ff3f8599d9788e1d2cb454> /usr/lib/liblzma.5.dylib
0x1922cc000 - 0x1922e6fff libCRFSuite.dylib arm64  <ac663b865b6b38429a40878701aa484a> /usr/lib/libCRFSuite.dylib
0x1922e7000 - 0x192310fff libarchive.2.dylib arm64  <667b9f199ef63c89b05bf1ea9a3ffe13> /usr/lib/libarchive.2.dylib
0x192311000 - 0x192312fff liblangid.dylib arm64  <a74f4f8a2d533e1f926044f052cc5b7d> /usr/lib/liblangid.dylib
0x192313000 - 0x1925e1fff Foundation arm64  <7d40355e685036cc803455e5cbf6245f> /System/Library/Frameworks/Foundation.framework/Foundation
0x1925e2000 - 0x19268efff libBLAS.dylib arm64  <fa29c2ad87a73ccea2885d9182faee53> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libBLAS.dylib
0x19268f000 - 0x1929d1fff libLAPACK.dylib arm64  <6df40b0afcbb35a48d63e2fa8ec03b1b> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libLAPACK.dylib
0x1929d2000 - 0x192c74fff vImage arm64  <8b797590cf983693b4c3b6b83dc4ba29> /System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage
0x192c75000 - 0x192c97fff libvMisc.dylib arm64  <5bcbb491c0a03816a7634797852c21ad> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libvMisc.dylib
0x192c98000 - 0x192cacfff libLinearAlgebra.dylib arm64  <1adeb99764f63e9e8ef1225bb7a5120d> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libLinearAlgebra.dylib
0x192cad000 - 0x192cbefff libSparseBLAS.dylib arm64  <515a7b8f5c433b709c1f6d205b9a73d2> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libSparseBLAS.dylib
0x192cbf000 - 0x192d37fff libvDSP.dylib arm64  <80294f738c053c4991fa3ab4e867218e> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libvDSP.dylib
0x192d38000 - 0x192d38fff vecLib arm64  <15dc1eafe1f8377d9cab3ba5c7e488be> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/vecLib
0x192d39000 - 0x192d39fff Accelerate arm64  <32a527bb13a63e37bf50c725b008e9d5> /System/Library/Frameworks/Accelerate.framework/Accelerate
0x192d3a000 - 0x193289fff CoreGraphics arm64  <52f191594f523f41880280896948b786> /System/Library/Frameworks/CoreGraphics.framework/CoreGraphics
0x19328a000 - 0x19329efff GraphicsServices arm64  <7c0dd118a4bc37dc8fab6449abde7ff9> /System/Library/PrivateFrameworks/GraphicsServices.framework/GraphicsServices
0x19329f000 - 0x1932eafff AppSupport arm64  <bdaad3a71677315bb126c4a73a1bcb9e> /System/Library/PrivateFrameworks/AppSupport.framework/AppSupport
0x1932eb000 - 0x19340efff MobileCoreServices arm64  <e035420bfabe3f28bc6eef0a144ac1d1> /System/Library/Frameworks/MobileCoreServices.framework/MobileCoreServices
0x19340f000 - 0x193467fff BaseBoard arm64  <210cb4a9a0073c7b9e0b3d437cc1aa4b> /System/Library/PrivateFrameworks/BaseBoard.framework/BaseBoard
0x193468000 - 0x193473fff AssertionServices arm64  <7ca242e983fd3c0f805d51fca8a4c46a> /System/Library/PrivateFrameworks/AssertionServices.framework/AssertionServices
0x193474000 - 0x1934a0fff BackBoardServices arm64  <c333604ae8123e3cbb46fe26f233beb9> /System/Library/PrivateFrameworks/BackBoardServices.framework/BackBoardServices
0x1934a5000 - 0x1934f4fff FrontBoardServices arm64  <00b3c2ff89f53d3dba0069b6bb5a56bd> /System/Library/PrivateFrameworks/FrontBoardServices.framework/FrontBoardServices
0x1934f8000 - 0x19352bfff SpringBoardServices arm64  <d2c3d08eff3f3119a6f4eb1a0a180305> /System/Library/PrivateFrameworks/SpringBoardServices.framework/SpringBoardServices
0x19352c000 - 0x193540fff MobileKeyBag arm64  <a78d40cc257231978e752c5a81cd1356> /System/Library/PrivateFrameworks/MobileKeyBag.framework/MobileKeyBag
0x193541000 - 0x193549fff IOSurface arm64  <9a22349e905539a0a1598af6d7fe9cc9> /System/Library/PrivateFrameworks/IOSurface.framework/IOSurface
0x19354a000 - 0x193555fff liblockdown.dylib arm64  <ab36b2ace988302c89207cb290ff4a76> /usr/lib/liblockdown.dylib
0x193556000 - 0x19356cfff CrashReporterSupport arm64  <326017f8d07d3e7cb338dda00fa888f7> /System/Library/PrivateFrameworks/CrashReporterSupport.framework/CrashReporterSupport
0x19356d000 - 0x19356ffff IOSurfaceAccelerator arm64  <7b7c2b7ea506374cb3902b7408d5d4bf> /System/Library/PrivateFrameworks/IOSurfaceAccelerator.framework/IOSurfaceAccelerator
0x193570000 - 0x1935b0fff AppleJPEG arm64  <b2fd4ef37aaf38f58311e33ea1683082> /System/Library/PrivateFrameworks/AppleJPEG.framework/AppleJPEG
0x1935b1000 - 0x193b43fff ImageIO arm64  <f5ddfe623d4f3a338ae75c666ea10815> /System/Library/Frameworks/ImageIO.framework/ImageIO
0x193b44000 - 0x193b4afff TCC arm64  <c9f168508185369591dfcd1c1cf9b6a3> /System/Library/PrivateFrameworks/TCC.framework/TCC
0x193b4b000 - 0x193b4ffff AggregateDictionary arm64  <4be0041fb69b358cada4eeabbf22adf3> /System/Library/PrivateFrameworks/AggregateDictionary.framework/AggregateDictionary
0x193b50000 - 0x193b5cfff PowerLog arm64  <e5003d8e49d0390c8a67da790407e704> /System/Library/PrivateFrameworks/PowerLog.framework/PowerLog
0x193b5d000 - 0x193bc5fff libTelephonyUtilDynamic.dylib arm64  <4a1e447a97f43b91a92ee731c2a4286b> /usr/lib/libTelephonyUtilDynamic.dylib
0x193bc6000 - 0x193bd8fff CommonUtilities arm64  <486d816afdc431aaa2ef67b229cf4e96> /System/Library/PrivateFrameworks/CommonUtilities.framework/CommonUtilities
0x193bd9000 - 0x193bedfff libcompression.dylib arm64  <c764915fa0ec384f8a1759e63235b5a9> /usr/lib/libcompression.dylib
0x193bee000 - 0x193e8cfff CoreData arm64  <980c0f8663a0330d8b5fb541c22e7b66> /System/Library/Frameworks/CoreData.framework/CoreData
0x193e8d000 - 0x193e92fff libCoreVMClient.dylib arm64  <3a28c232b17430839305f9d17745e247> /System/Library/Frameworks/OpenGLES.framework/libCoreVMClient.dylib
0x193e93000 - 0x193e98fff IOAccelerator arm64  <f4d5cd421bd03a52b40c991fd1c73806> /System/Library/PrivateFrameworks/IOAccelerator.framework/IOAccelerator
0x193e99000 - 0x193e9afff libCVMSPluginSupport.dylib arm64  <7110757134ea3599b3d739db2ea6f48a> /System/Library/Frameworks/OpenGLES.framework/libCVMSPluginSupport.dylib
0x193e9b000 - 0x193e9efff libCoreFSCache.dylib arm64  <2147b40a3d713d53b221e8f40ca5ac7f> /System/Library/Frameworks/OpenGLES.framework/libCoreFSCache.dylib
0x193e9f000 - 0x193ee2fff libGLImage.dylib arm64  <c2e2de9ee34236558c89d7fe9bc0116c> /System/Library/Frameworks/OpenGLES.framework/libGLImage.dylib
0x193ee3000 - 0x193eedfff libGFXShared.dylib arm64  <058e54d10e9838c5bea32a75f199c2db> /System/Library/Frameworks/OpenGLES.framework/libGFXShared.dylib
0x193eee000 - 0x193ef6fff IOMobileFramebuffer arm64  <811101a668313da993fa3881ac7cddef> /System/Library/PrivateFrameworks/IOMobileFramebuffer.framework/IOMobileFramebuffer
0x193ef7000 - 0x193ef7fff libmetal_timestamp.dylib arm64  <2bbf481d5e4a35aea434cd15f9d6a182> /System/Library/PrivateFrameworks/GPUCompiler.framework/libmetal_timestamp.dylib
0x193ef8000 - 0x193f56fff Metal arm64  <ff1261ae94e03c19964dda0546e189fd> /System/Library/Frameworks/Metal.framework/Metal
0x193f57000 - 0x193f61fff OpenGLES arm64  <52e0ecb1f2c23cc4a26345d035127679> /System/Library/Frameworks/OpenGLES.framework/OpenGLES
0x193f62000 - 0x193f86fff CoreVideo arm64  <581f5f9967923c4983c1373dfa23195b> /System/Library/Frameworks/CoreVideo.framework/CoreVideo
0x193f87000 - 0x193f89fff OAuth arm64  <23d43697c1b130ed814eaddbd9851e0d> /System/Library/PrivateFrameworks/OAuth.framework/OAuth
0x193f91000 - 0x193fcefff Accounts arm64  <ba89d108cfef37ae91b70116c6d7c66d> /System/Library/Frameworks/Accounts.framework/Accounts
0x193fcf000 - 0x1940c1fff libiconv.2.dylib arm64  <c85933d9062f32ac885047aadb359e88> /usr/lib/libiconv.2.dylib
0x1940c2000 - 0x194212fff CoreAudio arm64  <8ff5628b7e9b36efb6b746e6ea3e9088> /System/Library/Frameworks/CoreAudio.framework/CoreAudio
0x194213000 - 0x194216fff UserFS arm64  <13d40ea4a3e032b199465cddc45c8479> /System/Library/PrivateFrameworks/UserFS.framework/UserFS
0x194217000 - 0x194325fff CoreMedia arm64  <98e944101d7b3745ae7bc0e43a8b59cb> /System/Library/Frameworks/CoreMedia.framework/CoreMedia
0x194326000 - 0x19432cfff libcupolicy.dylib arm64  <e88ddf38bf5a3f2583b7f1c9b1af4e76> /usr/lib/libcupolicy.dylib
0x19432d000 - 0x1943bafff CoreTelephony arm64  <c5ef9b84bce0312e96b3faed5e424110> /System/Library/Frameworks/CoreTelephony.framework/CoreTelephony
0x1943bb000 - 0x1944c8fff libFontParser.dylib arm64  <2784cc1e874a395bb3ea2f7c3382c62f> /System/Library/PrivateFrameworks/FontServices.framework/libFontParser.dylib
0x1944c9000 - 0x194558fff VideoToolbox arm64  <d0baea0326d13f66ae8623f19aa1ac76> /System/Library/Frameworks/VideoToolbox.framework/VideoToolbox
0x194559000 - 0x194559fff FontServices arm64  <a4b99cf7d62630aeb2f8c8e865a8fe34> /System/Library/PrivateFrameworks/FontServices.framework/FontServices
0x19455a000 - 0x1946a7fff CoreText arm64  <9d73af39afa63ea68673374a3862426b> /System/Library/Frameworks/CoreText.framework/CoreText
0x1946a8000 - 0x1946c2fff ProtocolBuffer arm64  <11c5f55b03ff32c6b25310171c1c7afe> /System/Library/PrivateFrameworks/ProtocolBuffer.framework/ProtocolBuffer
0x1946c3000 - 0x1946ebfff PersistentConnection arm64  <65b64570bee63c0580880163a91c230f> /System/Library/PrivateFrameworks/PersistentConnection.framework/PersistentConnection
0x1946ec000 - 0x1946f2fff DataMigration arm64  <5961a23a26153867b4bb8c80c19799d0> /System/Library/PrivateFrameworks/DataMigration.framework/DataMigration
0x1946f3000 - 0x194b53fff AudioToolbox arm64  <3ea60e00d2383ae498996690ab1fdbdd> /System/Library/Frameworks/AudioToolbox.framework/AudioToolbox
0x194b54000 - 0x194d2cfff QuartzCore arm64  <6dc61ad83fc03f799792d1cb950622f7> /System/Library/Frameworks/QuartzCore.framework/QuartzCore
0x194d2d000 - 0x194d33fff Netrb arm64  <81262209ce983a5197fc2da41fc3b6a3> /System/Library/PrivateFrameworks/Netrb.framework/Netrb
0x194d34000 - 0x194d44fff libcmph.dylib arm64  <7f719c3d948530c78be18a40b3ea59aa> /usr/lib/libcmph.dylib
0x194d45000 - 0x194d65fff libmis.dylib arm64  <cd871843480d31b8b074ac87e66cb63d> /usr/lib/libmis.dylib
0x194d66000 - 0x194e59fff LanguageModeling arm64  <8483753bf96f3484b448a47883cd5ab4> /System/Library/PrivateFrameworks/LanguageModeling.framework/LanguageModeling
0x194e5a000 - 0x194f41fff ManagedConfiguration arm64  <d9e33a6cfa163270bb50a1a6e370ea95> /System/Library/PrivateFrameworks/ManagedConfiguration.framework/ManagedConfiguration
0x194f42000 - 0x194f58fff libmarisa.dylib arm64  <f0eea40d2c0a33a58d7cd2c9b52da4b7> /usr/lib/libmarisa.dylib
0x194f59000 - 0x195029fff ProofReader arm64  <1596b3e0c7c43398ac19ac08a5460868> /System/Library/PrivateFrameworks/ProofReader.framework/ProofReader
0x19502a000 - 0x195034fff MediaAccessibility arm64  <7b482ef272bf34fcb742c2afd236b626> /System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility
0x195035000 - 0x195045fff MobileAsset arm64  <66b4c8da5b103557b258b9bac8d37772> /System/Library/PrivateFrameworks/MobileAsset.framework/MobileAsset
0x195046000 - 0x1950b7fff ColorSync arm64  <d4fa34368b923aaa8679c1bb8433b9b5> /System/Library/PrivateFrameworks/ColorSync.framework/ColorSync
0x1950b8000 - 0x195128fff MetalPerformanceShaders arm64  <251f089c067b30d4922d67dc463d2300> /System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders
0x195129000 - 0x195558fff FaceCore arm64  <04c8c7b7a36d3d98a96817f4365b3439> /System/Library/PrivateFrameworks/FaceCore.framework/FaceCore
0x195559000 - 0x1955d4fff Quagga arm64  <068db048c7e03054b73e3691592d1287> /System/Library/PrivateFrameworks/Quagga.framework/Quagga
0x1955d5000 - 0x19579ffff CoreImage arm64  <8c3df52ae00634d0ac530ceea391edac> /System/Library/Frameworks/CoreImage.framework/CoreImage
0x1957a0000 - 0x1957ecfff TextInput arm64  <25840bba5f6e347290d6f9e13dc2adf7> /System/Library/PrivateFrameworks/TextInput.framework/TextInput
0x1957ed000 - 0x1957fdfff libAccessibility.dylib arm64  <f9f8b21c43c33c20a44455087fb58d36> /usr/lib/libAccessibility.dylib
0x19580d000 - 0x196163fff JavaScriptCore arm64  <8f81ebee9a4c3d42903b89e5e73a54a7> /System/Library/Frameworks/JavaScriptCore.framework/JavaScriptCore
0x196164000 - 0x196381fff StoreServices arm64  <2f9d7cd0f84d33f3bce6134c7acb25c5> /System/Library/PrivateFrameworks/StoreServices.framework/StoreServices
0x196382000 - 0x197475fff WebCore arm64  <ef6c9957757b3733a0e5d447fe4455aa> /System/Library/PrivateFrameworks/WebCore.framework/WebCore
0x197476000 - 0x19749ffff libxslt.1.dylib arm64  <28d75f17d5b03dfd8717fea9677e1720> /usr/lib/libxslt.1.dylib
0x1974a0000 - 0x197585fff WebKitLegacy arm64  <2c47baeea50b32f6bab25105cfc7df1f> /System/Library/PrivateFrameworks/WebKitLegacy.framework/WebKitLegacy
0x197586000 - 0x19764efff CoreUI arm64  <c5f28ba5feee3fa68d7d42174e006ad5> /System/Library/PrivateFrameworks/CoreUI.framework/CoreUI
0x19764f000 - 0x197676fff DictionaryServices arm64  <95116730515a356b990751cd0513b912> /System/Library/PrivateFrameworks/DictionaryServices.framework/DictionaryServices
0x197677000 - 0x197678fff HangTracer arm64  <d433b5e6e9d93fbeb761be625f893433> /System/Library/PrivateFrameworks/HangTracer.framework/HangTracer
0x197679000 - 0x1976c9fff PhysicsKit arm64  <abbda49ec9cb3e67934ed6ca38a54986> /System/Library/PrivateFrameworks/PhysicsKit.framework/PhysicsKit
0x1976ca000 - 0x1977a2fff UIFoundation arm64  <bf83b49e8565319c87a0d11769135836> /System/Library/PrivateFrameworks/UIFoundation.framework/UIFoundation
0x1977af000 - 0x19853bfff UIKit arm64  <1804405f7b2a3e77a349b53163b09cdb> /System/Library/Frameworks/UIKit.framework/UIKit
0x19853c000 - 0x198564fff CoreBluetooth arm64  <12009b6e55113d8da05a44a02f819497> /System/Library/Frameworks/CoreBluetooth.framework/CoreBluetooth
0x198565000 - 0x19858afff DataAccessExpress arm64  <ee3cce236aaf3b77b59100acd44c2f29> /System/Library/PrivateFrameworks/DataAccessExpress.framework/DataAccessExpress
0x19858b000 - 0x1985acfff NetworkStatistics arm64  <a0b0f25f321b35fba72fcdddcc334766> /System/Library/PrivateFrameworks/NetworkStatistics.framework/NetworkStatistics
0x1985ad000 - 0x198636fff AddressBook arm64  <54368e264b6b3cf5bfc46b20d8c407be> /System/Library/Frameworks/AddressBook.framework/AddressBook
0x198637000 - 0x198794fff CoreMotion arm64  <32e6ecff39443a1687ad3f188b97b09f> /System/Library/Frameworks/CoreMotion.framework/CoreMotion
0x198795000 - 0x1987c2fff CacheDelete arm64  <8da9a120ed5f31fcb904a48633c0612c> /System/Library/PrivateFrameworks/CacheDelete.framework/CacheDelete
0x1987c3000 - 0x1987d0fff CoreAUC arm64  <671a13f17b6d3f7da0b81595e1957bc5> /System/Library/PrivateFrameworks/CoreAUC.framework/CoreAUC
0x1987d1000 - 0x198d72fff MediaToolbox arm64  <6a968276d7153a80b6059d561045f83d> /System/Library/Frameworks/MediaToolbox.framework/MediaToolbox
0x198d73000 - 0x198f1efff Celestial arm64  <4b71ffa1c45d346887475b45f842fb12> /System/Library/PrivateFrameworks/Celestial.framework/Celestial
0x198f1f000 - 0x198f2efff IntlPreferences arm64  <41f26994496f3c4981cd2939832f54d6> /System/Library/PrivateFrameworks/IntlPreferences.framework/IntlPreferences
0x198f2f000 - 0x198f31fff CoreDuetDebugLogging arm64  <a16fb61a2c833e93852b77b5b5520db2> /System/Library/PrivateFrameworks/CoreDuetDebugLogging.framework/CoreDuetDebugLogging
0x198f32000 - 0x198f46fff CoreDuetDaemonProtocol arm64  <486d428723a038fc994d0b926b4a84af> /System/Library/PrivateFrameworks/CoreDuetDaemonProtocol.framework/CoreDuetDaemonProtocol
0x198f47000 - 0x19901cfff CoreDuet arm64  <8ab25716062a373c9bb1c54fc647d0fe> /System/Library/PrivateFrameworks/CoreDuet.framework/CoreDuet
0x19901d000 - 0x1991cffff AVFoundation arm64  <4fed94e1676f3b50928f9be1cb375e75> /System/Library/Frameworks/AVFoundation.framework/AVFoundation
0x1991d0000 - 0x199202fff libtidy.A.dylib arm64  <daa87ffd63a43a5aa805bce93b398a11> /usr/lib/libtidy.A.dylib
0x199203000 - 0x199269fff IMFoundation arm64  <a2ca1e8dfe203f928802b19dcca8fbf7> /System/Library/PrivateFrameworks/IMFoundation.framework/IMFoundation
0x19926a000 - 0x1998f7fff GeoServices arm64  <43d3e18725873a68be5c828ce90a623a> /System/Library/PrivateFrameworks/GeoServices.framework/GeoServices
0x1998f8000 - 0x1998f9fff DiagnosticLogCollection arm64  <944c96e416a331efbf7bab3839ccd10d> /System/Library/PrivateFrameworks/DiagnosticLogCollection.framework/DiagnosticLogCollection
0x1998fa000 - 0x1998fbfff Marco arm64  <bff480036e39364fafccd764c6dbaeb4> /System/Library/PrivateFrameworks/Marco.framework/Marco
0x1998fc000 - 0x199980fff CoreLocation arm64  <28f1187102a531528323faead1645b58> /System/Library/Frameworks/CoreLocation.framework/CoreLocation
0x199981000 - 0x199986fff ConstantClasses arm64  <9d635c1173f83a22b1d1b1e53c16f6bb> /System/Library/PrivateFrameworks/ConstantClasses.framework/ConstantClasses
0x199987000 - 0x199991fff libChineseTokenizer.dylib arm64  <10321183aad832e6988d2cb25dc1169e> /usr/lib/libChineseTokenizer.dylib
0x199992000 - 0x199c12fff libmecabra.dylib arm64  <7d15e6ac19ea3b3d8b1fb3dc6f5a79ed> /usr/lib/libmecabra.dylib
0x199c13000 - 0x199c64fff IDSFoundation arm64  <ae619c4ab4343eaaaf51a9d5cc3acd3f> /System/Library/PrivateFrameworks/IDSFoundation.framework/IDSFoundation
0x199c65000 - 0x199d2bfff IDS arm64  <f6a74797fdb43277b966a72442b3a803> /System/Library/PrivateFrameworks/IDS.framework/IDS
0x199d2c000 - 0x199d49fff MediaServices arm64  <b4725476785c34aa8518b5b4a9ae13e6> /System/Library/PrivateFrameworks/MediaServices.framework/MediaServices
0x199d4a000 - 0x199d8afff AuthKit arm64  <fb557bb1badb3e298bbc0b0945322e33> /System/Library/PrivateFrameworks/AuthKit.framework/AuthKit
0x199d8b000 - 0x199d90fff libheimdal-asn1.dylib arm64  <166bb8b0eaa6368d836a7702b4ade694> /usr/lib/libheimdal-asn1.dylib
0x199d91000 - 0x199e3ffff MediaRemote arm64  <aed85a16fdeb30c7bb1e12c1ca7361ed> /System/Library/PrivateFrameworks/MediaRemote.framework/MediaRemote
0x199e40000 - 0x199fc7fff MobileSpotlightIndex arm64  <5383bbd06360330b8ad7f3d857bf0f87> /System/Library/PrivateFrameworks/MobileSpotlightIndex.framework/MobileSpotlightIndex
0x199fc8000 - 0x199fe8fff PlugInKit arm64  <354f2edb8c5e3f4b95155b744b56ecc8> /System/Library/PrivateFrameworks/PlugInKit.framework/PlugInKit
0x199fe9000 - 0x19a015fff ProtectedCloudStorage arm64  <1be1f41a77f138e7b177db7aea32c460> /System/Library/PrivateFrameworks/ProtectedCloudStorage.framework/ProtectedCloudStorage
0x19a016000 - 0x19a031fff libresolv.9.dylib arm64  <1088f2b7d38b3b29b79ea0a4de8eb83c> /usr/lib/libresolv.9.dylib
0x19a032000 - 0x19a047fff ApplePushService arm64  <404f080a4df430a6a4012958806b6e57> /System/Library/PrivateFrameworks/ApplePushService.framework/ApplePushService
0x19a048000 - 0x19a097fff ContactsFoundation arm64  <b2d796f48a0d336fb6f3d048299c9aa3> /System/Library/PrivateFrameworks/ContactsFoundation.framework/ContactsFoundation
0x19a098000 - 0x19a09dfff ParsecSubscriptionServiceSupport arm64  <53e5ef742ffa3af287a2fc7c1a0fbc6a> /System/Library/PrivateFrameworks/ParsecSubscriptionServiceSupport.framework/ParsecSubscriptionServiceSupport
0x19a09e000 - 0x19a146fff Contacts arm64  <74d5212f603f3e9ca9522262ad9aeacf> /System/Library/Frameworks/Contacts.framework/Contacts
0x19a147000 - 0x19a195fff CoreSpotlight arm64  <dd56f04ebe813448a8009a72e6a5d4c0> /System/Library/Frameworks/CoreSpotlight.framework/CoreSpotlight
0x19a196000 - 0x19a1befff vCard arm64  <6177f1a1d74e3a788a888913862c8487> /System/Library/PrivateFrameworks/vCard.framework/vCard
0x19a1bf000 - 0x19a24bfff VoiceServices arm64  <4a9d9d7c87063e31ac02c51832d12985> /System/Library/PrivateFrameworks/VoiceServices.framework/VoiceServices
0x19a24c000 - 0x19a29afff SAObjects arm64  <cb968a4c94793cee9f24675abe5a5b93> /System/Library/PrivateFrameworks/SAObjects.framework/SAObjects
0x19a337000 - 0x19a3d3fff AssistantServices arm64  <0521c745ab213216a63de8d14b08b4b0> /System/Library/PrivateFrameworks/AssistantServices.framework/AssistantServices
0x19a4de000 - 0x19a4fafff AppleIDSSOAuthentication arm64  <86f02c1364c433578943f63cfdd6d63f> /System/Library/PrivateFrameworks/AppleIDSSOAuthentication.framework/AppleIDSSOAuthentication
0x19a50c000 - 0x19a57afff AppleAccount arm64  <ddcedeb71dde3b96af5ef48fafdbcaa3> /System/Library/PrivateFrameworks/AppleAccount.framework/AppleAccount
0x19a57b000 - 0x19a57ffff CommunicationsFilter arm64  <c09574c4d9f132d080f543f4d2bc7c1d> /System/Library/PrivateFrameworks/CommunicationsFilter.framework/CommunicationsFilter
0x19a580000 - 0x19a5a4fff ChunkingLibrary arm64  <2d79fcffe0a8325bb364c297197c2d65> /System/Library/PrivateFrameworks/ChunkingLibrary.framework/ChunkingLibrary
0x19a5a5000 - 0x19a5b0fff CaptiveNetwork arm64  <5d095ea1c7e93865a577f73201dc43df> /System/Library/PrivateFrameworks/CaptiveNetwork.framework/CaptiveNetwork
0x19a5b1000 - 0x19a5dffff EAP8021X arm64  <87f61032e0c23911a752f834b3bf1ffa> /System/Library/PrivateFrameworks/EAP8021X.framework/EAP8021X
0x19a5e0000 - 0x19a5e6fff AssetCacheServices arm64  <075670ecd32d3fbeb5b3ce6da947f51b> /System/Library/PrivateFrameworks/AssetCacheServices.framework/AssetCacheServices
0x19a5e7000 - 0x19a6c0fff MMCS arm64  <92dc4de4192c362591d4b4e019af6db1> /System/Library/PrivateFrameworks/MMCS.framework/MMCS
0x19a6c1000 - 0x19a6f1fff MobileWiFi arm64  <b8634bee980a3594aeadee3f06a7186d> /System/Library/PrivateFrameworks/MobileWiFi.framework/MobileWiFi
0x19a6f2000 - 0x19a734fff ContentIndex arm64  <19eda95a34c639d093b9dc61c0b3f4e6> /System/Library/PrivateFrameworks/ContentIndex.framework/ContentIndex
0x19a735000 - 0x19a73dfff MobileIcons arm64  <b73eaea49b493f708a793777ef16cfce> /System/Library/PrivateFrameworks/MobileIcons.framework/MobileIcons
0x19a793000 - 0x19a7c3fff Bom arm64  <9545e5dc0248350ea55266dafdf1c3f7> /System/Library/PrivateFrameworks/Bom.framework/Bom
0x19a7c4000 - 0x19a7cbfff CertUI arm64  <8fcb899eb96c3ca2a44f0f439a26b4fb> /System/Library/PrivateFrameworks/CertUI.framework/CertUI
0x19a81d000 - 0x19a87bfff CoreDAV arm64  <11b89b735ad93ffca4d0efb854df9ab8> /System/Library/PrivateFrameworks/CoreDAV.framework/CoreDAV
0x19a88a000 - 0x19a89efff UserManagement arm64  <26bc451e92fd3d18a4f237c34798385a> /System/Library/PrivateFrameworks/UserManagement.framework/UserManagement
0x19a89f000 - 0x19a967fff CorePDF arm64  <83ce0866f79834d1b91423333a40f932> /System/Library/PrivateFrameworks/CorePDF.framework/CorePDF
0x19a968000 - 0x19a99cfff iCalendar arm64  <a6f2dc3bfc41351c9dded418139ee97d> /System/Library/PrivateFrameworks/iCalendar.framework/iCalendar
0x19a9a5000 - 0x19aa04fff CalendarFoundation arm64  <d8bae7d431e5328ca1d2716a42f29eae> /System/Library/PrivateFrameworks/CalendarFoundation.framework/CalendarFoundation
0x19aa05000 - 0x19aa0bfff IncomingCallFilter arm64  <62bdc5aac98c371ea540084da652f001> /System/Library/PrivateFrameworks/IncomingCallFilter.framework/IncomingCallFilter
0x19ab04000 - 0x19ab9cfff CalendarDatabase arm64  <5997d40c47c632ad848c0da62416fff7> /System/Library/PrivateFrameworks/CalendarDatabase.framework/CalendarDatabase
0x19ab9d000 - 0x19abe2fff CalendarDaemon arm64  <737888a19d1d3e2eb55023f964582a8d> /System/Library/PrivateFrameworks/CalendarDaemon.framework/CalendarDaemon
0x19abe3000 - 0x19acb2fff EventKit arm64  <39e4a110cfb53e2f83a3f54255233a03> /System/Library/Frameworks/EventKit.framework/EventKit
0x19acb3000 - 0x19afb6fff WebKit arm64  <17220d29d7b2334db44059e6ff7f61e5> /System/Library/Frameworks/WebKit.framework/WebKit
0x19afb7000 - 0x19affdfff WebBookmarks arm64  <e79d45649948354a8585b97e91ec1380> /System/Library/PrivateFrameworks/WebBookmarks.framework/WebBookmarks
0x19affe000 - 0x19b146fff ContactsUI arm64  <a5d684c338fb3ad9a5758cb81cae2073> /System/Library/Frameworks/ContactsUI.framework/ContactsUI
0x19b147000 - 0x19b901fff ModelIO arm64  <54c4cfa7d1ce37648feac1566c688eae> /System/Library/Frameworks/ModelIO.framework/ModelIO
0x19b902000 - 0x19b908fff DAAPKit arm64  <e2f5c35af4e73c0b8880725e14fc12e7> /System/Library/PrivateFrameworks/DAAPKit.framework/DAAPKit
0x19b98b000 - 0x19ba28fff TelephonyUtilities arm64  <4bb95814034337aba0e676c1c33c9627> /System/Library/PrivateFrameworks/TelephonyUtilities.framework/TelephonyUtilities
0x19ba29000 - 0x19ba59fff GLKit arm64  <133a53348b2e3a1bb872e9f13871a842> /System/Library/Frameworks/GLKit.framework/GLKit
0x19ba5a000 - 0x19bcc4fff MusicLibrary arm64  <0b694389c0443d8f905235f5b346964c> /System/Library/PrivateFrameworks/MusicLibrary.framework/MusicLibrary
0x19bd04000 - 0x19bddbfff AddressBookUI arm64  <83d4193ac4dd31b9b1690a0ecd1cd5f0> /System/Library/Frameworks/AddressBookUI.framework/AddressBookUI
0x19bddc000 - 0x19beb9fff CloudKit arm64  <57ee991dbad6343aa5b1da537ef0c65f> /System/Library/Frameworks/CloudKit.framework/CloudKit
0x19beba000 - 0x19bf17fff iTunesStore arm64  <6b3c659271773947b78c6f2bdcec916e> /System/Library/PrivateFrameworks/iTunesStore.framework/iTunesStore
0x19bf18000 - 0x19bf1efff CloudPhotoServices arm64  <381563610a603902b5a5bc6eb71411fb> /System/Library/PrivateFrameworks/CloudPhotoServices.framework/CloudPhotoServices
0x19bf1f000 - 0x19c015fff CloudPhotoLibrary arm64  <5aea2d9cd31a314c8c4107445241a237> /System/Library/PrivateFrameworks/CloudPhotoLibrary.framework/CloudPhotoLibrary
0x19c066000 - 0x19c08dfff AssetsLibraryServices arm64  <da2212f776a73a3cbae134918f26336c> /System/Library/PrivateFrameworks/AssetsLibraryServices.framework/AssetsLibraryServices
0x19c08e000 - 0x19c126fff HomeSharing arm64  <16daec5c02433eb4947ae0cce5a58ce1> /System/Library/PrivateFrameworks/HomeSharing.framework/HomeSharing
0x19c127000 - 0x19c155fff ACTFramework arm64  <4109d6d2547c3ff6947434cd22492bfd> /System/Library/PrivateFrameworks/ACTFramework.framework/ACTFramework
0x19c156000 - 0x19c161fff DCIMServices arm64  <e83ee6449bd43b719ee6689f153fb4eb> /System/Library/PrivateFrameworks/DCIMServices.framework/DCIMServices
0x19c162000 - 0x19c28ffff CoreMediaStream arm64  <73e65daffe5c3aa7a54d64817cf62583> /System/Library/PrivateFrameworks/CoreMediaStream.framework/CoreMediaStream
0x19c290000 - 0x19c2a8fff PhotosFormats arm64  <0a62b66d803e3ade95d2e303f5dc92ce> /System/Library/PrivateFrameworks/PhotosFormats.framework/PhotosFormats
0x19c2a9000 - 0x19c2b0fff XPCKit arm64  <238c5b445c233772b1456419738eb478> /System/Library/PrivateFrameworks/XPCKit.framework/XPCKit
0x19c2b1000 - 0x19c62ffff MediaPlayer arm64  <7f0e6ef0d236360a96c4eb58067704f0> /System/Library/Frameworks/MediaPlayer.framework/MediaPlayer
0x19c630000 - 0x19c716fff CameraKit arm64  <dced4b1aaa6c3025a834b265f84c86db> /System/Library/PrivateFrameworks/CameraKit.framework/CameraKit
0x19c71f000 - 0x19c73afff MediaStream arm64  <c09f05a03f4531c8a40dc8c1b0e5d352> /System/Library/PrivateFrameworks/MediaStream.framework/MediaStream
0x19c73b000 - 0x19cac1fff PhotoLibraryServices arm64  <e254ca00e46f3ca8a90a29c3018e3dc3> /System/Library/PrivateFrameworks/PhotoLibraryServices.framework/PhotoLibraryServices
0x19cac2000 - 0x19caf8fff PrototypeTools arm64  <a219ff307840362bb385c5776a3fac25> /System/Library/PrivateFrameworks/PrototypeTools.framework/PrototypeTools
0x19caf9000 - 0x19cb67fff libprotobuf.dylib arm64  <0281cb59de1d3e858bd9e59dddaf41ff> /usr/lib/libprotobuf.dylib
0x19cf8d000 - 0x19cfc0fff DataDetectorsCore arm64  <36ddb64003543f17a4ae5f50cf5ca896> /System/Library/PrivateFrameworks/DataDetectorsCore.framework/DataDetectorsCore
0x19cfcf000 - 0x19d212fff libAWDSupportFramework.dylib arm64  <5d208ba22cbd3626a213751b9f5a08da> /usr/lib/libAWDSupportFramework.dylib
0x19d252000 - 0x19d28ffff WirelessDiagnostics arm64  <940dc9eff3fd3865ae91cb2af37e86aa> /System/Library/PrivateFrameworks/WirelessDiagnostics.framework/WirelessDiagnostics
0x19d290000 - 0x19d39dfff Photos arm64  <c22e0114511937ffae76791cf6df1686> /System/Library/Frameworks/Photos.framework/Photos
0x19d3d6000 - 0x19d3f7fff LatentSemanticMapping arm64  <c54ce6484a1c39fab4525ee48fdc2529> /System/Library/PrivateFrameworks/LatentSemanticMapping.framework/LatentSemanticMapping
0x19d453000 - 0x19d46cfff GenerationalStorage arm64  <3b7cc03de3dc311e8ebbc53a86643300> /System/Library/PrivateFrameworks/GenerationalStorage.framework/GenerationalStorage
0x19d46d000 - 0x19d478fff CoreRecents arm64  <5919be3a936736239f53dc6057ac945e> /System/Library/PrivateFrameworks/CoreRecents.framework/CoreRecents
0x19d579000 - 0x19d58cfff AssetsLibrary arm64  <f7bc78a1943130c387a5d9661bd239cb> /System/Library/Frameworks/AssetsLibrary.framework/AssetsLibrary
0x19d5c4000 - 0x19dbbafff VectorKit arm64  <b85fe130baa13e698e5b15fbd7b395f3> /System/Library/PrivateFrameworks/VectorKit.framework/VectorKit
0x19dbbb000 - 0x19ddcafff MapKit arm64  <b01e1b5efea930fd846d824a43fb6faa> /System/Library/Frameworks/MapKit.framework/MapKit
0x19dded000 - 0x19ddfffff QuickLookThumbnailing arm64  <9b111083e2b1386091f3f5f4a6cdbc3c> /System/Library/PrivateFrameworks/QuickLookThumbnailing.framework/QuickLookThumbnailing
0x19df03000 - 0x19df99fff QuickLook arm64  <b0790b2a84023f60a91da6260ad9c948> /System/Library/Frameworks/QuickLook.framework/QuickLook
0x19e111000 - 0x19e189fff libnetwork.dylib arm64  <5a78675ccd2f3b50ba5ae3e5ef088969> /usr/lib/libnetwork.dylib
0x19e19d000 - 0x19e21bfff Network arm64  <7c97545661d93a238dd3201713c90bbe> /System/Library/PrivateFrameworks/Network.framework/Network
0x19e222000 - 0x19e2c1fff Social arm64  <b62cec6888253e85963301dc2604e2d1> /System/Library/Frameworks/Social.framework/Social
0x19e603000 - 0x19e65afff ImageCapture arm64  <c4b1b77966ae350997986c475fdfe0b5> /System/Library/PrivateFrameworks/ImageCapture.framework/ImageCapture
0x19e65b000 - 0x19e671fff iPhotoMigrationSupport arm64  <19c46322a6f53dbe9be9b943e7287943> /System/Library/PrivateFrameworks/iPhotoMigrationSupport.framework/iPhotoMigrationSupport
0x19e672000 - 0x19e692fff SharedUtils arm64  <7daf1f044294321fa2b2969c4ad56422> /System/Library/Frameworks/LocalAuthentication.framework/Support/SharedUtils.framework/SharedUtils
0x19e6a2000 - 0x19e735fff PhotoLibrary arm64  <1b1a9ced905a31f688a0bfdbbca0a26f> /System/Library/PrivateFrameworks/PhotoLibrary.framework/PhotoLibrary
0x19e936000 - 0x19e948fff LocalAuthentication arm64  <518efa2598233531b5a1dceb013241cc> /System/Library/Frameworks/LocalAuthentication.framework/LocalAuthentication
0x19e949000 - 0x19e97ffff CalendarUIKit arm64  <d1e7c63a537d3d4cb13bf24664b3a287> /System/Library/PrivateFrameworks/CalendarUIKit.framework/CalendarUIKit
0x19e9f1000 - 0x19ebb4fff EventKitUI arm64  <574a0b3800163a0da0f5bd4cbe44359e> /System/Library/Frameworks/EventKitUI.framework/EventKitUI
0x19ebb5000 - 0x19ec3cfff CoreRecognition arm64  <5d295f3c0f423b35865e89a188cc203a> /System/Library/PrivateFrameworks/CoreRecognition.framework/CoreRecognition
0x19ec6a000 - 0x19ec9cfff Pegasus arm64  <16f175f3c4b5343fbba9f33a019df587> /System/Library/PrivateFrameworks/Pegasus.framework/Pegasus
0x19ed54000 - 0x19ed9dfff AVKit arm64  <a22d21e340683071aae9308e7e98ea46> /System/Library/Frameworks/AVKit.framework/AVKit
0x19ee91000 - 0x19f0a2fff SafariShared arm64  <629e722f6c3838da8af537ba034508a8> /System/Library/PrivateFrameworks/SafariShared.framework/SafariShared
0x19f0a3000 - 0x19f0b5fff SiriTasks arm64  <cf2be6f4dba133c18c64e8450b1147b7> /System/Library/PrivateFrameworks/SiriTasks.framework/SiriTasks
0x19f302000 - 0x19f385fff PhotoEditSupport arm64  <ccaac3637c1533759af0c9a548ea1ea5> /System/Library/PrivateFrameworks/PhotoEditSupport.framework/PhotoEditSupport
0x19f94f000 - 0x19f996fff WebUI arm64  <d15df032bcc43ceb9c859d5914c8efa0> /System/Library/PrivateFrameworks/WebUI.framework/WebUI
0x19f9c2000 - 0x19fe2dfff PhotosUI arm64  <727e1e51350e3803990f0555d9bc6e6c> /System/Library/Frameworks/PhotosUI.framework/PhotosUI
0x19fe2e000 - 0x19fed1fff SafariServices arm64  <4e514c6f1a353a3c9e7da75ef28d0b9d> /System/Library/Frameworks/SafariServices.framework/SafariServices
0x1a090f000 - 0x1a0948fff DataDetectorsUI arm64  <6235f738e81b358f92616efc4946fc47> /System/Library/PrivateFrameworks/DataDetectorsUI.framework/DataDetectorsUI
0x1a09dd000 - 0x1a0b18fff NetworkExtension arm64  <a1ca06c7188c3cfe81a1a08e680aadcf> /System/Library/Frameworks/NetworkExtension.framework/NetworkExtension
0x1a1029000 - 0x1a1059fff WirelessProximity arm64  <46b5f46f92af38b2965f7d21bd9ed3aa> /System/Library/PrivateFrameworks/WirelessProximity.framework/WirelessProximity
0x1a12c7000 - 0x1a1344fff CoreHandwriting arm64  <2c2abc16390631299955479f738bf139> /System/Library/PrivateFrameworks/CoreHandwriting.framework/CoreHandwriting
0x1a144a000 - 0x1a14dcfff MediaPlatform arm64  <a956f56e7f5137f6b6fcd0012b79f0f7> /System/Library/PrivateFrameworks/MediaPlatform.framework/MediaPlatform
0x1a1f86000 - 0x1a1fe2fff CoreBrightness arm64  <85ad1b8cc94739a6a1e65cfb56900997> /System/Library/PrivateFrameworks/CoreBrightness.framework/CoreBrightness
0x1a22f2000 - 0x1a241bfff StoreServicesCore arm64  <265f2ee887003ee7a6f622c9278f1861> /System/Library/PrivateFrameworks/StoreServicesCore.framework/StoreServicesCore
0x1a295b000 - 0x1a2d9efff MediaLibraryCore arm64  <02b1955ea96135e195d5bea426c6702e> /System/Library/PrivateFrameworks/MediaLibraryCore.framework/MediaLibraryCore
0x1a33d8000 - 0x1a34dbfff AnnotationKit arm64  <4adbb0dc3383365badb357f588f292c0> /System/Library/PrivateFrameworks/AnnotationKit.framework/AnnotationKit
0x1a585b000 - 0x1a5871fff WebContentAnalysis arm64  <fff0b12fb1223875927a88dcb859eba5> /System/Library/PrivateFrameworks/WebContentAnalysis.framework/WebContentAnalysis
0x1a5c24000 - 0x1a5ebafff RawCamera arm64  <fea3d8d380c333d79a0aa40656d20742> /System/Library/CoreServices/RawCamera.bundle/RawCamera
0x1a5ee6000 - 0x1a5efafff libCGInterfaces.dylib arm64  <a94effd0df4d3bb691067ae3ae270125> /System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/Libraries/libCGInterfaces.dylib
0x1a6d86000 - 0x1a6d94fff AppleFSCompression arm64  <a1afd6c88f183b0896626b220de4d2c2> /System/Library/PrivateFrameworks/AppleFSCompression.framework/AppleFSCompression
0x1a6d95000 - 0x1a6da0fff AppleIDAuthSupport arm64  <5ef7f5e8da2c364b9d459b7280615c26> /System/Library/PrivateFrameworks/AppleIDAuthSupport.framework/AppleIDAuthSupport
0x1a7a56000 - 0x1a7a7cfff CoreServicesInternal arm64  <3a007d98794d3e3a9d1f377b2c3619ee> /System/Library/PrivateFrameworks/CoreServicesInternal.framework/CoreServicesInternal
0x1a7da5000 - 0x1a7daffff DiagnosticExtensions arm64  <bf963a4bf08d3b82b4e1832f8ea2984e> /System/Library/PrivateFrameworks/DiagnosticExtensions.framework/DiagnosticExtensions
0x1a81b6000 - 0x1a81c2fff libGSFontCache.dylib arm64  <e35b6863bb623df5b8e7735a66f76e50> /System/Library/PrivateFrameworks/FontServices.framework/libGSFontCache.dylib
0x1a81c3000 - 0x1a81f4fff libTrueTypeScaler.dylib arm64  <de847921d0693dc48e78f8847117768a> /System/Library/PrivateFrameworks/FontServices.framework/libTrueTypeScaler.dylib
0x1a91a3000 - 0x1a91d4fff MarkupUI arm64  <31815c047f8c362fb2935f7c4e962292> /System/Library/PrivateFrameworks/MarkupUI.framework/MarkupUI
0x1a9597000 - 0x1a95a0fff MobileStorage arm64  <d52617f7f151376f9c76c912ee5f1f68> /System/Library/PrivateFrameworks/MobileStorage.framework/MobileStorage
0x1aa114000 - 0x1aa141fff SafariSafeBrowsing arm64  <887d44eb862f3bdb80970559178b5a79> /System/Library/PrivateFrameworks/SafariSafeBrowsing.framework/SafariSafeBrowsing
0x1aac09000 - 0x1aade4fff libFosl_dynamic.dylib arm64  <0aa33a84bd8630f29c6fc401fa0ffd5e> /usr/lib/libFosl_dynamic.dylib
0x1ab1fb000 - 0x1ab22afff libpcap.A.dylib arm64  <983b5efbde5d30238673d8b74a8a2653> /usr/lib/libpcap.A.dylib
0x1ab266000 - 0x1ab337fff AVFAudio arm64  <b1a0fc23635a35bb8ba6e8fe869cae92> /System/Library/Frameworks/AVFoundation.framework/Frameworks/AVFAudio.framework/AVFAudio
0x1ab338000 - 0x1ab341fff ProactiveEventTracker arm64  <5b8319222fbb31c58bd392b6d4fc1035> /System/Library/PrivateFrameworks/ProactiveEventTracker.framework/ProactiveEventTracker
0x1ab342000 - 0x1ab498fff Intents arm64  <242a81c86a613c7e961765694a6f9e89> /System/Library/Frameworks/Intents.framework/Intents
0x1ab5dc000 - 0x1ab5fffff UserNotifications arm64  <0dd7c46e70d23483a26b02bfed7be22f> /System/Library/Frameworks/UserNotifications.framework/UserNotifications
0x1ab60f000 - 0x1ab61dfff PersonaKit arm64  <11315b9f03073d42a84dfedc91b43347> /System/Library/PrivateFrameworks/PersonaKit.framework/PersonaKit
0x1ab61e000 - 0x1ab814fff CVML arm64  <cc734717fab431688fad56eb0b3f139a> /System/Library/PrivateFrameworks/CVML.framework/CVML
0x1ab90e000 - 0x1ab9c0fff Navigation arm64  <714104bfd3273e248e37e1ce6fd2f5a9> /System/Library/PrivateFrameworks/Navigation.framework/Navigation
0x1aba89000 - 0x1abc13fff TextureIO arm64  <c54172604d14378eb9ca8a71942a9a7e> /System/Library/PrivateFrameworks/TextureIO.framework/TextureIO
0x1ac12f000 - 0x1ac179fff ContactsUICore arm64  <e046c6d1c0d33c0dadfe2a5c663a6683> /System/Library/PrivateFrameworks/ContactsUICore.framework/ContactsUICore
0x1ac93d000 - 0x1ac95afff SearchFoundation arm64  <f06ed152e1b83f57aded04d6d2f82869> /System/Library/PrivateFrameworks/SearchFoundation.framework/SearchFoundation
0x1acf7c000 - 0x1ad00efff AGXMetalA10 arm64  <50964eb76a073316a65516b3b4efbe93> /System/Library/Extensions/AGXMetalA10.bundle/AGXMetalA10
0x1ad02d000 - 0x1ad03ffff libBNNS.dylib arm64  <4fe669ed8f7e3fd6aa4687faa52c18e9> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libBNNS.dylib
0x1ad040000 - 0x1ad045fff libQuadrature.dylib arm64  <b42c49db566e3e5f9577adbfcf2e0a42> /System/Library/Frameworks/Accelerate.framework/Frameworks/vecLib.framework/libQuadrature.dylib
0x1ad496000 - 0x1ad4a7fff CoreEmoji arm64  <a5aa53b703bf3c669425672d599a24f9> /System/Library/PrivateFrameworks/CoreEmoji.framework/CoreEmoji
0x1ad4a8000 - 0x1ad4c0fff CoreInterest arm64  <d85bf0b4967a338cacb3403da52ec1c2> /System/Library/PrivateFrameworks/CoreInterest.framework/CoreInterest
0x1ad650000 - 0x1ad683fff CoreParsec arm64  <4316c778b9483a708b2640bc07b315d0> /System/Library/PrivateFrameworks/CoreParsec.framework/CoreParsec
0x1ad6df000 - 0x1ad711fff DifferentialPrivacy arm64  <b79e65b3133f3ba1a977f99a9369478d> /System/Library/PrivateFrameworks/DifferentialPrivacy.framework/DifferentialPrivacy
0x1ad973000 - 0x1ad973fff IntentsFoundation arm64  <011ec9d36ee0348aa1c272522b03a06f> /System/Library/PrivateFrameworks/IntentsFoundation.framework/IntentsFoundation
0x1ada92000 - 0x1adb5afff NLP arm64  <41213ee6dc4c3221876add1679d24b72> /System/Library/PrivateFrameworks/NLP.framework/NLP
0x1adbec000 - 0x1adc5cfff PDFKit arm64  <5d68e68df9fc3665980822dd386778ad> /System/Library/PrivateFrameworks/PDFKit.framework/PDFKit
0x1ae143000 - 0x1ae3a7fff PhotosUICore arm64  <471cf0efdf60387ab49c1cce59a68873> /System/Library/PrivateFrameworks/PhotosUICore.framework/PhotosUICore
0x1aec5b000 - 0x1aecd2fff libate.dylib arm64  <afb1757e1bdd3804b372511c4c3ba662> /usr/lib/libate.dylib
0x1aecd3000 - 0x1aecd3fff libcoretls.dylib arm64  <3798381066cd3288b95a25164d224a06> /usr/lib/libcoretls.dylib
0x1aecd4000 - 0x1aecd5fff libcoretls_cfhelpers.dylib arm64  <f528dac189a931439165cffb8579f5ef> /usr/lib/libcoretls_cfhelpers.dylib

EOF
