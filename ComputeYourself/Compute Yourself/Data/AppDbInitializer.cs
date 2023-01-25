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