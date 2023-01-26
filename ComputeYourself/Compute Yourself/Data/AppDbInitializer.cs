using ComputeYourself.Data.Enums;
using ComputeYourself.Models;

namespace ComputeYourself.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateAsyncScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cpus.Any())
                {
                    context.Cpus.AddRange(new List<Cpu>()
                    {
                        new()
                        {
                            Name = "FUJITSU Intel Xeon Silver 4310 12C 2.10 GHz",
                            Description = "The real server eq!!!!!!!!!!!!",
                            productOfficialWebsite = "https://www.intel.com/content/www/us/en/products/sku/215277/intel-xeon-silver-4310-processor-18m-cache-2-10-ghz/specifications.html",
                            mainImage = "https://c1.neweggimages.com/ProductImageCompressAll1280/19-118-335-V01.jpg",
                            modelNumber = "PY-CP62XH",
                            Price = 1946.49M,
                            Brand = "Intel",
                            Warranty = 2,
                            Rating = 0,
                            Socket = "FCLGA4189",
                            ManufacturerCooler = false,
                            L3Cache = 18,
                            TotalCache = 18,
                            Cores = 12,
                            Threads = 24,
                            Igpu = "null",
                            TDP = 120,
                            CoreClock = 2100,
                            TurboCoreClock = 2100
                        },
                        new()
                        {
                            Name = "Intel Core i9-11900K 3.50GHz S1200 BOX",
                            Description = "About this item: The processor features Socket LGA-1200 socket for installation on the PCB, 16 MB of L3 cache rapidly retrieves the most used data available to improve system performance, 14 nm design offers great efficiency for computing, delivers nimble processing with balanced cost, performance, and power, To boost graphics and visual quality, the chipset has a built in Intel UHD Graphics 750 controller. Supports up to 3 monitors.",
                            productOfficialWebsite = "https://ark.intel.com/content/www/us/en/ark/products/212325/intel-core-i911900k-processor-16m-cache-up-to-5-30-ghz.html",
                            mainImage = "https://alphaszerviz.hu/product/intel-core-i9-11900-dobozos-lga1200-processzor.jpg",
                            modelNumber = "BX8070811900K",
                            Price = 603.00M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            ManufacturerCooler = false,
                            L3Cache = 16,
                            TotalCache = 16,
                            Cores = 8,
                            Threads = 16,
                            Igpu = "null",
                            TDP = 235,
                            CoreClock = 3500,
                            TurboCoreClock = 5300
                        },
                        new()
                        {
                            Name = "Intel Core i7 3,4GHz LGA1700 30MB (i7-13700K) box ",
                            Description = "About this item: 16 cores (8 P-cores + 8 E-cores) and 24 threads. Integrated Intel UHD Graphics 770 included, Performance hybrid architecture integrates two core microarchitectures, prioritizing and distributing workloads to optimize performance, Up to 5.4 GHz unlocked. 30M Cache, Compatible with Intel 600 series and 700 series chipset-based motherboards, Turbo Boost Max Technology 3.0, and PCIe 5.0 & 4.0 support. Intel Optane Memory support. No thermal solution included",
                            productOfficialWebsite = "https://ark.intel.com/content/www/us/en/ark/products/230500/intel-core-i713700k-processor-30m-cache-up-to-5-40-ghz.html",
                            mainImage = "https://s13emagst.akamaized.net/products/49567/49566533/images/res_3d25521f42e62caf57050f507bc62330.jpg",
                            modelNumber = "BX8071513700K",
                            Price = 419.00M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            ManufacturerCooler = false,
                            L3Cache = 24,
                            TotalCache = 44,
                            Cores = 14,
                            Threads = 20,
                            Igpu = "null",
                            TDP = 253,
                            CoreClock = 3400,
                            TurboCoreClock = 5400
                        },
                        new()
                        {
                            Name = "INTEL Core i5-13600KF 3,5GHz 24MB box",
                            Description = "About this item: 14 cores (6 P-cores + 8 E-cores) and 20 threads, Performance hybrid architecture integrates two core microarchitectures, prioritizing and distributing workloads to optimize performance, Up to 5.1 GHz unlocked. 24M Cache, Compatible with Intel 600 series and 700 series chipset-based motherboards, Turbo Boost Max Technology 3.0, and PCIe 5.0 & 4.0 support. Intel Optane Memory support. No thermal solution included. Discrete graphics required",
                            productOfficialWebsite = "https://ark.intel.com/content/www/us/en/ark/products/212271/intel-core-i511400f-processor-12m-cache-up-to-4-40-ghz.html",
                            mainImage = "https://s13emagst.akamaized.net/products/49567/49566529/images/res_f223ba4c86ab65f1665eac672c219459.jpg",
                            modelNumber = "BX8071513600KF",
                            Price = 329.00M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            ManufacturerCooler = false,
                            L3Cache = 24,
                            TotalCache = 44,
                            Cores = 14,
                            Threads = 20,
                            Igpu = "null",
                            TDP = 181,
                            CoreClock = 3500,
                            TurboCoreClock = 5100
                        },
                        new()
                        {
                            Name = "Intel Core i3 3,30GHz LGA1700 12MB (i3-12100F) box",
                            Description = "About this item: The processor features Socket LGA-1200 socket for installation on the PCB, 16 MB of L3 cache rapidly retrieves the most used data available to improve system performance, 14 nm design offers great efficiency for computing, delivers nimble processing with balanced cost, performance, and power, To boost graphics and visual quality, the chipset has a built in Intel UHD Graphics 750 controller. Supports up to 3 monitors.",
                            productOfficialWebsite = "https://ark.intel.com/content/www/us/en/ark/products/132223/intel-core-i312100f-processor-12m-cache-up-to-4-30-ghz.html",
                            mainImage = "https://s13emagst.akamaized.net/products/42720/42719120/images/res_496fc9608c5482edcfa13ccd56e0392d.jpg",
                            modelNumber = "BX8071512100F",
                            Price = 117.00M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1700",
                            ManufacturerCooler = false,
                            L3Cache = 12,
                            TotalCache = 17,
                            Cores = 4,
                            Threads = 8,
                            Igpu = "null",
                            TDP = 89,
                            CoreClock = 3300,
                            TurboCoreClock = 4300
                        },
                        new()
                        {
                            Name = "Intel Core i5 2,60GHz LGA1200 12MB (i5-11400F) box ",
                            Description = "About this item: Compatible with Intel 500 series & select Intel 400 series chipset based motherboards, Intel Optane Memory Support, PCIe Gen 4.0 Support, Thermal solution included",
                            productOfficialWebsite = "https://ark.intel.com/content/www/us/en/ark/products/212271/intel-core-i511400f-processor-12m-cache-up-to-4-40-ghz.html",
                            mainImage = "https://p1.akcdn.net/full/793089615.intel-i5-11400f-6-core-2-6ghz-lga1200-box.jpg",
                            modelNumber = "BX8070811400F",
                            Price = 183.00M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            ManufacturerCooler = true,
                            L3Cache = 12,
                            TotalCache = 12,
                            Cores = 6,
                            Threads = 12,
                            Igpu = "null",
                            TDP = 65,
                            CoreClock = 2600,
                            TurboCoreClock = 4400
                        },
                        new()
                        {
                            Name = "AMD AM5 Ryzen 9 7950X - 4,5 GHz",
                            Description = "The 16-core powerhouse processor can do it all for the most demanding gamers and creators",
                            productOfficialWebsite = "https://www.amd.com/en/products/cpu/amd-ryzen-9-7950x",
                            mainImage = "https://www.amd.com/system/files/styles/600px/private/2022-11/1761310-amd-ryzen-9-7000-series-PIB-angle-1260x709.png?itok=_NVpbZqF",
                            modelNumber = "100-100000514WOF",
                            Price = 634.00M,
                            Brand = "AMD",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "AM5",
                            ManufacturerCooler = true,
                            L3Cache = 64,
                            TotalCache = 81,
                            Cores = 16,
                            Threads = 32,
                            Igpu = "null",
                            TDP = 170,
                            CoreClock = 4500,
                            TurboCoreClock = 5700
                        },
                        new()
                        {
                            Name = "AMD Ryzen 7 7700X BOX AM5 100-100000591WOF ",
                            Description = "Lead your team to victory with the top 8-core AMD gaming processor",
                            productOfficialWebsite = "https://www.amd.com/en/products/cpu/amd-ryzen-7-7700x",
                            mainImage = "https://www.amd.com/system/files/styles/600px/private/2022-11/1761310-amd-ryzen-7-7000-series-PIB-angle-1260x709.png?itok=qGZqRNcc",
                            modelNumber = "100-100000591WOF",
                            Price = 350.00M,
                            Brand = "AMD",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "AM5",
                            ManufacturerCooler = false,
                            L3Cache = 32,
                            TotalCache = 40,
                            Cores = 8,
                            Threads = 16,
                            Igpu = "null",
                            TDP = 105,
                            CoreClock = 4500,
                            TurboCoreClock = 5400
                        },
                        new()
                        {
                            Name = "AMD AM5 Ryzen 5 7600X - 4,7 GHz",
                            Description = "Get the 6-core gaming processor built for intense gaming action",
                            productOfficialWebsite = "https://www.amd.com/en/products/cpu/amd-ryzen-5-7600x",
                            mainImage = "https://www.amd.com/system/files/styles/600px/private/2022-11/1761310-amd-ryzen-5-7000-series-PIB-angle-1260x709.png?itok=c1aaXAmo",
                            modelNumber = "100-100000593WOF",
                            Price = 300.00M,
                            Brand = "AMD",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "AM5",
                            ManufacturerCooler = false,
                            L3Cache = 32,
                            TotalCache = 38,
                            Cores = 6,
                            Threads = 12,
                            Igpu = "null",
                            TDP = 65,
                            CoreClock = 3800,
                            TurboCoreClock = 4000
                        },
                        new()
                        {
                            Name = "AMD AM4 CPU Ryzen 3 4100 3.8GHz 6MB Cach",
                            Description = "AMD StoreMI Technology A fast and easy way to expand and accelerate the storage in a desktop PC ith an AMD Ryzen™ processor. AMD Ryzen™ VR-Ready Premium For the best possible VR experiences, AMD offers select Ryzen™ VR-Ready Premium processors. ",
                            productOfficialWebsite = "https://www.amd.com/en/products/cpu/amd-ryzen-3-4100",
                            mainImage = "https://2.pcx.hu/pcx_upload/termek-kepek/89/b/890517_1.jpg",
                            modelNumber = "100-100000510BOX",
                            Price = 72.00M,
                            Brand = "AMD",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "AM4",
                            ManufacturerCooler = false,
                            L3Cache = 4,
                            TotalCache = 6,
                            Cores = 4,
                            Threads = 8,
                            Igpu = "null",
                            TDP = 65,
                            CoreClock = 3800,
                            TurboCoreClock = 4000
                        },
                        new()
                        {
                            Name = "AMD AM4 CPU Ryzen 5 5600X",
                            Description = "AMD \"Zen 3\" Core Architecture The fastest cores in the world for PC gamers. AMD StoreMI Technology A fast and easy way to expand and accelerate the storage in a desktop PC with an AMD Ryzen™ processor. AMD Ryzen™ Master Utility The Simple and Powerful Overclocking Utility for AMD Ryzen™ processors.§",
                            productOfficialWebsite = "https://www.amd.com/en/products/cpu/amd-ryzen-5-5600xhtml",
                            mainImage = "https://www.amd.com/system/files/styles/600px/private/2022-11/1761310-amd-ryzen-5-7000-series-PIB-angle-1260x709.png?itok=c1aaXAmo",
                            modelNumber = "100-100000065BOX",
                            Price = 155.00M,
                            Brand = "AMD",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "AM4",
                            ManufacturerCooler = false,
                            L3Cache = 32,
                            TotalCache = 35,
                            Cores = 6,
                            Threads = 12,
                            Igpu = "null",
                            TDP = 65,
                            CoreClock = 3700,
                            TurboCoreClock = 4600
                        }
                    });
                    context.SaveChanges();
                }
                
                if (!context.CpuCoolers.Any())
                {
                    context.CpuCoolers.AddRange(new List<CpuCooler>()
                    {
                        new ()
                        {
                            Name = "Noctua NH-D15",
                            Description = "The NH-D15 chromax.black is an all-black version of Noctua’s award-winning" +
                                          "flagship model NH-D15 premium-quality quiet Cpu cooler. Thanks to the same" +
                                          "proven dual-tower heatsink design and NF-A15 PWM fans, it stays true to" +
                                          "the NH-D15’s successful formula of rivalling the performance of all-in-one" +
                                          "water coolers while maintaining superb quietness of operation",
                            productOfficialWebsite = "https://noctua.at/en/nh-d15-chromax-black",
                            mainImage = "https://noctua.at/pub/media/catalog/product/cache/74c1057f7991b4edb2bc7bdaa94de933/n/h/nh_d15_chromax_black_1_4.jpg",
                            modelNumber = "NH-D15-CH.BK",
                            Price = 141.92M,
                            Brand = "Noctua",
                            Warranty = 2,
                            Rating = 0,
                            CoolerType = "Air",
                            Height = 161,
                            CpuType = "LGA1150"
                        }
                    });
                    context.SaveChanges();
                }
                
                if (!context.Drives.Any())
                {
                    context.Drives.AddRange(new List<Drive>()
                    {
                        new()
                        {
                            Name = "SAMSUNG PM1643a 7.68TB Enterprise SSD",
                            Description = "PM1643a delivers high-value faster read speeds while improving TCO with" +
                                          " outstanding reliability, security and endurance. It provides a powerful" +
                                          " solution for mission-critical enterprise applications. It also provides" +
                                          " significantly more capacity up to 30.72 TB",
                            productOfficialWebsite = "https://semiconductor.samsung.com/ssd/enterprise-ssd/pm1643-pm1643a/mzilt7t6hala-00007/",
                            mainImage = "https://cdn.shopify.com/s/files/1/0034/7288/3779/products/MZILT3T8HBLS.jpg?v=1630685770",
                            modelNumber = "MZILT7T6HALA-00007",
                            Price = 1960.68M,
                            Brand = "Samsung",
                            Warranty = 2,
                            Rating = 0,
                            ConnectionType = "SATA3",
                            Capacity = 7680,
                            MaxWrite = 2000,
                            MaxRead = 2100
                        }
                    });
                    context.SaveChanges();
                }
                
                if (!context.Gpus.Any())
                {
                    context.Gpus.AddRange(new List<Gpu>()
                    {
                        new()
                        {
                            Name = "Zotac GAMING GeForce RTX 3090 Trinity OC nVidia 24GB GDDR6X 384bit ZT-A30900J-10P",
                            Description = "Get Amplified with the ZOTAC GAMING GeForce RTX™ 30 Series based on the" +
                                          "NVIDIA Ampere architecture. Built with enhanced RT Cores and Tensor Cores," +
                                          "new streaming multiprocessors, and superfast GDDR6X memory, the ZOTAC GAMING" +
                                          "GeForce RTX 3090 Trinity OC gives rise to the amplified gaming experience" +
                                          "with ultra graphics fidelity.",
                            productOfficialWebsite = "https://www.zotac.com/us/product/graphics_card/zotac-gaming-geforce-rtx-3090-trinity-oc",
                            mainImage = "https://www.zotac.com/download/files/styles/w1024/public/product_gallery/graphics_cards/zt-a30900j-10p-image01.jpg?itok=Y50uW-dp",
                            modelNumber = "ZT-A30900J-10P",
                            Price = 2336.98M,
                            Brand = "Nvidia",
                            Warranty = 2,
                            Rating = 5,
                            VideoChipset = "GeForceRTX3090Ti",
                            VramSize = 24,
                            VramType = "GDDR6",
                            RequiredPSU = 750,
                            Length = 317
                        }
                    });
                    context.SaveChanges();
                }
                
                if (!context.MotherBoards.Any())
                {
                    context.MotherBoards.AddRange(new List<MotherBoard>()
                    {
                        new()
                        {
                            Name = "ASROCK H310CM-DVS 90-MXB8K0-A0UAYZ",
                            Description = "Supports 9th and 8th Gen Intel® Core™ Processors (Socket 1151)" +
                                          "Supports DDR4 2666 1 PCIe 3.0 x16, 1 PCIe 2.0 x1 " +
                                          "Graphics Output Options: DVI-D, D-Sub " +
                                          "7.1 CH HD Audio (Realtek ALC887/897 Audio Codec) " +
                                          "4 SATA3 4 USB 3.1 Gen1 (2 Front, 2 Rear) " +
                                          "Supports Full Spike Protection, ASRock Live Update & APP Shop",
                            productOfficialWebsite = "https://www.asrock.com/mb/Intel/H310CM-DVS/index.asp",
                            mainImage = "https://www.asrock.com/mb/photo/H310CM-DVS(L1).png",
                            modelNumber = "90-MXB8K0-A0UAYZ",
                            Price = 59.85M,
                            Brand = "Intel",
                            Warranty = 0,
                            Rating = 0,
                            Socket = "LGA1200",
                            Chipset = "IntelH310",
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 2666,
                            MemorySockets = 2,
                            XMP = false,
                            MaxMemory = 32,
                            CForSLISupport = null,
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = null,
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 1,
                            SATA3 = 0,
                            M2 = 0,
                            USB2 = 4,
                            USB3 = 0,
                            USB31 = 2,
                            USBC = 0
                        }
                    });
                    context.SaveChanges();
                }
               
                if (!context.PcCases.Any())
                {
                    context.PcCases.AddRange(new List<PcCase>()
                    {
                        new()
                        {
                            Name = "ZALMAN Z-Machine 500 ZM-Z500",
                            Description = "Expensive",
                            productOfficialWebsite = "https://zalmanusa.com/products/z-machine-500-full-tower",
                            mainImage = "https://cdn.shopify.com/s/files/1/0102/9754/0666/products/B09NZP7GY7.MAIN_600x.jpg?v=1643831133",
                            modelNumber = "ZM-Z500",
                            Price = 1550.58M,
                            Brand = "Zalman",
                            Warranty = 2,
                            Rating = 0,
                            SizeCompatibility = SizeStandard.ATX,
                            MaxCpuCoolerHeight = 190,
                            MaxGpuLength = 602
                        }
                    });
                    context.SaveChanges();
                }
                
                if (!context.Psus.Any())
                {
                    context.Psus.AddRange(new List<Psu>()
                    {
                        new()
                        {
                            Name = "Seasonic Prime TX-1600 1600W Psu (PRIME-TX-1600)",
                            Description = "Pressing on with its One Seasonic Initiative, the PRIME TX, PRIME PX and" +
                                          "PRIME GX series became the successors to the Seasonic PRIME and PRIME" +
                                          "Ultra series. The PRIME Series has always demonstrated outstanding" +
                                          "performance and have become the epitome of technological excellence" +
                                          "and quality through the years",
                            productOfficialWebsite = "https://seasonic.com/prime-tx",
                            mainImage = "https://seasonic.com/pub/media/catalog/product/cache/3cbda8e892dc62fc02660815c2a4b231/p/r/prime-tx-1600-1300-back-panel-angled_1.jpg",
                            modelNumber = "PRIME-TX-1600",
                            Price = 651.39M,
                            Brand = "Seagate",
                            Warranty = 5,
                            Rating = 0,
                            Capacity = 1600,
                            Modular = true,
                            Classification = Classification.Platinum
                        }
                    });
                    context.SaveChanges();
                }
                
                if (!context.Rams.Any())
                {
                    context.Rams.AddRange(new List<Ram>()
                    {
                        new()
                        {
                            Name =
                                "CORSAIR Vengeance LPX Black DDR4, 4000MHz 32GB (2 x 16GB) memory CMK32GX4M2F4000C19",
                            Description = "4000MHz 32GB (2 x 16GB) memory CMK32GX4M2F4000C19",
                            productOfficialWebsite = "https://www.corsair.com/us/en/Categories/Products/Memory/VENGEANCE-LPX/p/CMK32GX4M2G4000C19",
                            mainImage = "https://www.corsair.com/us/en/medias/sys_master/images/images/hbc/h39/9650694783006/CMK32GX4M2G4000C19/Gallery/VENG_LPX_BLK_01/-CMK32GX4M2G4000C19-Gallery-VENG-LPX-BLK-01.png_1200Wx1200H",
                            modelNumber = "CMK32GX4M2F4000C19",
                            Price = 376.79M,
                            Brand = "Corsair",
                            Warranty = 10,
                            Rating = 0,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 4000,
                            Latency = 12,
                            HeatSink = true
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}