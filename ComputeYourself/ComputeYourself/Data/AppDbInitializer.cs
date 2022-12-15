using ComputeYourself.Data.Enums.CpuCooler;
using ComputeYourself.Data.Enums.Drive;
using ComputeYourself.Data.Enums.GPU;
using ComputeYourself.Data.Enums.MotherBoard;
using ComputeYourself.Data.Enums.PSU;
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

               

                // Cpu
                if (!context.Cpus.Any())
                {
                    context.Cpus.AddRange(new List<CPU>()
                    {
                        new CPU()
                        {
                            Name = "FUJITSU Intel Xeon Silver 4310 12C 2.10 GHz PY-CP62XH",
                            Description = "The real server eq!!!!!!!!!!!!",
                            Price = 754190,
                            Brand = ManuFacturerBrand.Intel,
                            Warranty = 2,
                            Rating = 0,
                            Socket = Enums.CPU.CpuType.LGA4189,
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

                // Cpu Cooler
                if (!context.CpuCoolers.Any())
                {
                    context.CpuCoolers.AddRange(new List<CpuCooler>()
                    {
                        new CpuCooler()
                        {
                            Name = "Noctua NH-D15 14cm chromax.black NH-D15 CH.BK",
                            Description = "The NH-D15 chromax.black is an all-black version of Noctua’s award-winning" +
                                          "flagship model NH-D15 premium-quality quiet CPU cooler. Thanks to the same" +
                                          "proven dual-tower heatsink design and NF-A15 PWM fans, it stays true to" +
                                          "the NH-D15’s successful formula of rivalling the performance of all-in-one" +
                                          "water coolers while maintaining superb quietness of operation",
                            Price = 54990,
                            Brand = ManuFacturerBrand.Noctua,
                            Warranty = 2,
                            Rating = 0,
                            CoolerType = CoolerTypes.Air,
                            Height = 161,
                            CpuType = Enums.CPU.CpuType.LGA1150
                        }
                    });
                    context.SaveChanges();
                }

                // Drive
                if (!context.Drives.Any())
                {
                    context.Drives.AddRange(new List<Drive>()
                    {
                        new Drive()
                        {
                            Name = "SAMSUNG PM1643a 7.68TB Enterprise SSD meghajtó (MZILT7T6HALA-00007)",
                            Description = "PM1643a delivers high-value faster read speeds while improving TCO with" +
                                          " outstanding reliability, security and endurance. It provides a powerful" +
                                          " solution for mission-critical enterprise applications. It also provides" +
                                          " significantly more capacity up to 30.72 TB",
                            Price = 759690,
                            Brand = ManuFacturerBrand.Samsung,
                            Warranty = 2,
                            Rating = 0,
                            ConnectionType = ConnectionTypes.SATA3,
                            Capacity = 7680,
                            MaxWrite = 2000,
                            MaxRead = 2100
                        }
                    });
                    context.SaveChanges();
                }

                // GPU
                if (!context.Gpus.Any())
                {
                    context.Gpus.AddRange(new List<GPU>()
                    {
                        new GPU()
                        {
                            Name = "Zotac GAMING GeForce RTX 3090 Trinity OC nVidia 24GB GDDR6X 384bit ZT-A30900J-10P",
                            Description = "Get Amplified with the ZOTAC GAMING GeForce RTX™ 30 Series based on the" +
                                          "NVIDIA Ampere architecture. Built with enhanced RT Cores and Tensor Cores," +
                                          "new streaming multiprocessors, and superfast GDDR6X memory, the ZOTAC GAMING" +
                                          "GeForce RTX 3090 Trinity OC gives rise to the amplified gaming experience" +
                                          "with ultra graphics fidelity.",
                            Price = 905490,
                            Brand = ManuFacturerBrand.Nvidia,
                            Warranty = 2,
                            Rating = 5,
                            VideoChipset = VideoChipsets.GeForceRTX3090Ti,
                            VramSize = 24,
                            VramType = VramTypes.GDDR6,
                            RequiredPSU = 750,
                            Length = 317
                        }
                    });
                    context.SaveChanges();
                }

                // MotherBoard
                if (!context.MotherBoards.Any())
                {
                    context.MotherBoards.AddRange(new List<MotherBoard>()
                    {
                        new MotherBoard()
                        {
                            Name = "ASROCK H310CM-DVS 90-MXB8K0-A0UAYZ",
                            Description = "Supports 9th and 8th Gen Intel® Core™ Processors (Socket 1151)" +
                                          "Supports DDR4 2666 1 PCIe 3.0 x16, 1 PCIe 2.0 x1 " +
                                          "Graphics Output Options: DVI-D, D-Sub " +
                                          "7.1 CH HD Audio (Realtek ALC887/897 Audio Codec) " +
                                          "4 SATA3 4 USB 3.1 Gen1 (2 Front, 2 Rear) " +
                                          "Supports Full Spike Protection, ASRock Live Update & APP Shop",
                            Price = 23190,
                            Brand = ManuFacturerBrand.Intel,
                            Warranty = 0,
                            Rating = 0,
                            Socket = CpuType.LGA1200,
                            Chipset = ChipsetType.IntelH310,
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = MemoryCompatibility.DDR4,
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

                // PcCase
                if (!context.PcCases.Any())
                {
                    context.PcCases.AddRange(new List<PcCase>()
                    {
                        new PcCase()
                        {
                            Name = "ZALMAN Z-Machine 500 ZM-Z500",
                            Description = "Expensive",
                            Price = 600790,
                            Brand = ManuFacturerBrand.Zalman,
                            Warranty = 2,
                            Rating = 0,
                            SizeCompatibility = SizeStandard.ATX,
                            MaxCpuCoolerHeight = 190,
                            MaxGpuLength = 602
                        }
                    });
                    context.SaveChanges();
                }

                // PSU
                if (!context.Psus.Any())
                {
                    context.Psus.AddRange(new List<PSU>()
                    {
                        new PSU()
                        {
                            Name = "Seasonic Prime TX-1600 1600W PSU (PRIME-TX-1600)",
                            Description = "Pressing on with its One Seasonic Initiative, the PRIME TX, PRIME PX and" +
                                          "PRIME GX series became the successors to the Seasonic PRIME and PRIME" +
                                          "Ultra series. The PRIME Series has always demonstrated outstanding" +
                                          "performance and have become the epitome of technological excellence" +
                                          "and quality through the years",
                            Price = 252390,
                            Brand = ManuFacturerBrand.Seagate,
                            Warranty = 5,
                            Rating = 0,
                            Capacity = 1600,
                            Modular = true,
                            Classification = Classification.Platinum
                        }
                    });
                    context.SaveChanges();
                }

                // RAM
                if (!context.Rams.Any())
                {
                    context.Rams.AddRange(new List<RAM>()
                    {
                        new RAM()
                        {
                            Name =
                                "CORSAIR Vengeance LPX Black DDR4, 4000MHz 32GB (2 x 16GB) memory CMK32GX4M2F4000C19",
                            Description = "4000MHz 32GB (2 x 16GB) memory CMK32GX4M2F4000C19",
                            Price = 145990,
                            Brand = ManuFacturerBrand.Corsair,
                            Warranty = 10,
                            Rating = 0,
                            Size = 32,
                            MemoryType = MemoryCompatibility.DDR4,
                            Frequency = 4000,
                            Latency = 12,
                            HeatSink = true
                        }
                    });
                    context.SaveChanges();
                }

                // Media
                if (!context.Medias.Any())
                {
                    context.Medias.AddRange(new List<Media>()
                    {
                        new Media()
                        {
                            MediaURL = "https://www.pcx.hu/fujitsu-intel-xeon-silver-4310-12c-2-10-ghz-py-cp62xh-00647645"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.pcx.hu/processzor-huto-noctua-nh-d15-14cm-chromax-black-nh-d15-ch-bk-00775422"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.pcx.hu/ssd_meghajtok?isFiltered=1&categoryId=12176&type=&search=&filter[price][min]=694524"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.zotac.com/us/product/graphics_card/zotac-gaming-geforce-rtx-3090-trinity-oc"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.asrock.com/mb/Intel/H310CM-DVS/index.asp"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.pcx.hu/asrock-h310cm-dvs-90-mxb8k0-a0uayz-00128778"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.pcx.hu/haz-zalman-z-machine-500-zm-z500-00520366"
                        },
                        new Media()
                        {
                            MediaURL = "https://www.pcx.hu/corsair-vengeance-lpx-fekete-ddr4-4000mhz-32gb-2-x-16gb-memoria-cmk32gx4m2f4000c19-00195455"
                        },
                    });
                    context.SaveChanges();

                }
                //CPU & Media
                if (!context.CpuMedias.Any())
                {
                    context.CpuMedias.AddRange(new List<Cpu_Media>()
                    {
                        new Cpu_Media()
                        {
                            CpuId = 1,
                            MediaId = 1
                        }
                    });
                    context.SaveChanges();
                }
                //CpuCooler & Media
                if (!context.CpuCoolerMedias.Any())
                {
                    context.CpuCoolerMedias.AddRange(new List<CpuCooler_Media>()
                    {
                        new CpuCooler_Media()
                        {
                            CpuCoolerId = 1,
                            MediaId = 2
                        }
                    });
                    context.SaveChanges();
                }
                //Drive & Media
                if (!context.DriveMedias.Any())
                {
                    context.DriveMedias.AddRange(new List<Drive_Media>()
                    {
                        new Drive_Media()
                        {
                            DriveId = 1,
                            MediaId = 3
                        }
                    });
                    context.SaveChanges();
                }
                //GPU & Media
                if (!context.GpuMedias.Any())
                {
                    context.GpuMedias.AddRange(new List<Gpu_Media>()
                    {
                        new Gpu_Media()
                        {
                            GpuId = 1,
                            MediaId = 4
                        }
                    });
                    context.SaveChanges();
                }
                //MotherBoard & Media
                if (!context.MotherBoardMedias.Any())
                {
                    context.MotherBoardMedias.AddRange(new List<MotherBoard_Media>()
                    {
                        new MotherBoard_Media()
                        {
                            MotherBoardId = 1,
                            MediaId = 5
                        }
                    });
                    context.SaveChanges();
                }
                // PcCases & Media
                if (!context.PcCaseMedias.Any())
                {
                    context.PcCaseMedias.AddRange(new List<PcCase_Media>()
                    {
                        new PcCase_Media()
                        {
                            PcCaseId = 1,
                            MediaId = 6
                        }
                    });
                    context.SaveChanges();
                }
                //PSU & Media
                if (!context.PsuMedias.Any())
                {
                    context.PsuMedias.AddRange(new List<Psu_Media>()
                    {
                        new Psu_Media()
                        {
                            PsuId = 1,
                            MediaId = 8
                        }
                    });
                    context.SaveChanges();
                }
                //RAM & Media
                if (!context.RamMedias.Any())
                {
                    context.RamMedias.AddRange(new List<Ram_Media>()
                    {
                        new Ram_Media()
                        {
                            RamId = 1,
                            MediaId = 7
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
