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
                            Description = "About this item: The processor features Socket LGA-1200 socket for installation on the PCB," + 
                                          " 16 MB of L3 cache rapidly retrieves the most used data available to improve system performance," + 
                                          " 14 nm design offers great efficiency for computing, delivers nimble processing with balanced cost," + 
                                          " performance, and power, To boost graphics and visual quality, the chipset has a built in Intel UHD" + 
                                          " Graphics 750 controller. Supports up to 3 monitors.",
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
                            Description = "About this item: 16 cores (8 P-cores + 8 E-cores) and 24 threads. Integrated Intel" + 
                                          " UHD Graphics 770 included, Performance hybrid architecture integrates two core microarchitectures," + 
                                          " prioritizing and distributing workloads to optimize performance, Up to 5.4 GHz unlocked. 30M Cache, " + 
                                          "Compatible with Intel 600 series and 700 series chipset-based motherboards, Turbo Boost Max Technology" + 
                                          " 3.0, and PCIe 5.0 & 4.0 support. Intel Optane Memory support. No thermal solution included",
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
                            Description = "About this item: 14 cores (6 P-cores + 8 E-cores) and 20 threads, Performance hybrid" + 
                                          " architecture integrates two core microarchitectures, prioritizing and distributing workloads" + 
                                          " to optimize performance, Up to 5.1 GHz unlocked. 24M Cache, Compatible with Intel 600 series" + 
                                          " and 700 series chipset-based motherboards, Turbo Boost Max Technology 3.0, and PCIe 5.0 & 4.0" + 
                                          " support. Intel Optane Memory support. No thermal solution included. Discrete graphics required",
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
                            Description = "About this item: The processor features Socket LGA-1200 socket for" + 
                                          " installation on the PCB, 16 MB of L3 cache rapidly retrieves the most" + 
                                          " used data available to improve system performance, 14 nm design offers" + 
                                          " great efficiency for computing, delivers nimble processing with balanced" + 
                                          " cost, performance, and power, To boost graphics and visual quality, the" + 
                                          " chipset has a built in Intel UHD Graphics 750 controller. Supports up to 3 monitors.",
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
                            Description = "About this item: Compatible with Intel 500 series & select Intel 400 series" + 
                                          " chipset based motherboards, Intel Optane Memory Support, PCIe Gen 4.0 Support, Thermal solution included",
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
                            Description = "AMD StoreMI Technology A fast and easy way to expand and accelerate " + 
                                          "the storage in a desktop PC ith an AMD Ryzen™ processor. AMD Ryzen™ VR-Ready" + 
                                          " Premium For the best possible VR experiences, AMD offers select Ryzen™ VR-Ready Premium processors. ",
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
                            Description = "AMD \"Zen 3\" Core Architecture The fastest cores in the world for PC gamers." + 
                                          " AMD StoreMI Technology A fast and easy way to expand and accelerate the storage " + 
                                          "in a desktop PC with an AMD Ryzen™ processor. AMD Ryzen™ Master Utility The Simple " + 
                                          "and Powerful Overclocking Utility for AMD Ryzen™ processors.",
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
                        },                        
                        new ()
                        {
                            Name = "Noctua NH-P1",
                            Description = "The NH-P1 is Noctua’s first passive CPU cooler and has been custom-designed for fanless " + 
                                          "operation from the ground up: in enclosures with good natural convection, its six heatpipes " + 
                                          "and thick, widely spaced heatsink fins enable it to cool modern high-end CPUs with low to " + 
                                          "moderate heat dissipation completely passively (see setup guidelines and list of recommended cases)." + 
                                          " For further enhanced performance or semi-passive setups that only spin up their fans when necessary, " + 
                                          "the NH-P1 can be outfitted with a low-speed, ultra-quiet 120mm fan such as the NF-A12x25 LS-PWM. Topped" + 
                                          " off with the professional Torx-based SecuFirm2+ mounting system, Noctua’s award-winning NT-H2 thermal" + 
                                          " compound and a 6-year manufacturer’s warranty, the NH-P1 is the ideal cornerstone for premium-grade " + 
                                          "fanless or semi-passive builds",
                            productOfficialWebsite = "https://noctua.at/en/nh-p1",
                            mainImage = "https://noctua.at/pub/media/catalog/product/cache/0cdbea399f8ed06da39b3854134f6934/n/h/nh_p1_1_1.jpg",
                            modelNumber = "NH-P1-CH.BK",
                            Price = 110.00M,
                            Brand = "Noctua",
                            Warranty = 3,
                            Rating = 5,
                            CoolerType = "Air",
                            Height = 158,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " + 
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " + 
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "DeepCool AS500 PLUS WH",
                            Description = "DeepCool AS500 PLUS WH single tower CPU cooler boasts a five " + 
                                          "heat pipe, all white design with two 140mm PWM fans for great" + 
                                          " performance in a slim profile",
                            productOfficialWebsite = "https://www.deepcool.com/products/Cooling/cpuaircoolers/AS500-PLUS-WH-High-Performance-CPU-Cooler/2021/12847.shtml",
                            mainImage = "https://cdn.deepcool.com/public/ProductFile/DEEPCOOL/Cooling/CPUAirCoolers/AS500PLUS_WH/Gallery/608X760/01.jpg?fm=webp&q=60",
                            modelNumber = "AS500+WH",
                            Price = 105.00M,
                            Brand = "DeepCool",
                            Warranty = 3,
                            Rating = 4,
                            CoolerType = "Air",
                            Height = 159,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "COOLERMASTER Wraith Ripper TR4",
                            Description = "THE AIR COOLER FOR THE 32-CORE RYZEN THREADRIPPER 2990WX",
                            productOfficialWebsite = "https://www.coolermaster.com/catalog/coolers/cpu-air-coolers/wraith-ripper/",
                            mainImage = "https://cdn.coolermaster.com/media/assets/1003/wraith-ripper-gallery-1-image.png",
                            modelNumber = "CM-WRTR4",
                            Price = 130.00M,
                            Brand = "COOLERMASTER",
                            Warranty = 3,
                            Rating = 4,
                            CoolerType = "Air",
                            Height = 159,
                            CpuType = "AM4, AM5"
                        },
                        new ()
                        {
                            Name = "ZALMAN CNPS16X BLACK",
                            Description = "REAL RGB LED CPU COOLER WITH 4D PATENTED CORRUGATED FIN DESIGN",
                            productOfficialWebsite = "https://www.zalman.com/EN/Product/ProductDetail.do?pageIndex=1&pageSize=10&productSeq=1110&searchCategory1=0&searchCategory2=-99&searchCategory3=-99&searchKey=&searchWord=CNPS16X",
                            mainImage = "https://cdn.shopify.com/s/files/1/0102/9754/0666/products/B084ZXD7BH.MAIN_600x.jpg?v=1636763358",
                            modelNumber = "CNPS16X BK",
                            Price = 105.00M,
                            Brand = "ZALMAN",
                            Warranty = 3,
                            Rating = 5,
                            CoolerType = "Air",
                            Height = 165,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "Cooler Master - MasterAir MA620P",
                            Description = "The dual tower heatsink has a combination of 2 sets of" + 
                                          " heatsink towers with 2 sets of MasterFan MF120R RGB. The" + 
                                          " uniquely designed heatsink allows bigger and more spread" + 
                                          " out surface area, while the MF120R RGB fans give added air" + 
                                          " pressure from the outside and inside the heatsink to generate" + 
                                          " massive cooling performance",
                            productOfficialWebsite = "https://www.coolermaster.com/catalog/coolers/cpu-air-coolers/masterair-ma620p/",
                            mainImage = "https://cdn.coolermaster.com/media/assets/1025/1-ma620p_53-purpule-image.png",
                            modelNumber = "MAP-D6PN-218PC-R1",
                            Price = 60.92M,
                            Brand = "COOLERMASTER",
                            Warranty = 3,
                            Rating = 4,
                            CoolerType = "Air",
                            Height = 165,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "Thermaltake Frio Advanced ",
                            Description = "Heat-pipe Direct Touch Technology, Supports 230W Cooling Performance- 5" + 
                                          " x Ø6 mm heat-pipes direct touch CPU surface increasing heat conductivity." + 
                                          "- High density Aluminum fins allow larger surface area to quick dissipate heat." + 
                                          "- Premium thermal grease maximizes heat transfer from the CPU into the cooler base" + 
                                          " for rapid dissipation.Dual 13cm Over-clocking Fan, PWM function with 800~2,100 RPM" + 
                                          " Speed- A pair of high performance red bladed fans generate excellent cooling power." + 
                                          "- Tool-less fan installation provides great convenience for users." + 
                                          "- Vibration-absorbent gaskets decrease noise during operation." + 
                                          "- Fan speed at the lowest RPM provides good performance and very low noise." + 
                                          "Universal Socket Compatibility & Accessory Package- All-in-one back-plate design," + 
                                          " offers support for all Intel and AMD platforms- Universal socket support",
                            productOfficialWebsite = "http://nordic.thermaltake.com/products-model.aspx?id=C_00001822",
                            mainImage = "http://nordic.thermaltake.com/db/imgs/pdt/angle/CLP0596_e282b9bb7a99497089596476ea019e0f.jpg",
                            modelNumber = "CLP0596",
                            Price = 55.00M,
                            Brand = "Thermaltake",
                            Warranty = 3,
                            Rating = 4,
                            CoolerType = "Air",
                            Height = 159,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "Be quiet! Pure Rock 2 FX Black ARGB",
                            Description = "Pure Rock 2 FX Black combines vibrant ARGB illumination with high cooling" + 
                                          " efficiency and is excellent for quiet multimedia and gaming systems. With" + 
                                          " a Light Wings 120mm PWM high-speed fan, 150W TDP cooling efficiency and four" + 
                                          " 6mm high-performance heatpipes, Pure Rock 2 FX Black offers an excellent" + 
                                          " price-to-performance ratio.",
                            productOfficialWebsite = "https://www.bequiet.com/en/cpucooler/3739",
                            mainImage = "https://www.bequiet.com/admin/ImageServer.php?ID=ec6b4a43561@be-quiet.net&omitPreview=true&width=576",
                            modelNumber = "BK033",
                            Price = 141.92M,
                            Brand = "Be quiet!",
                            Warranty = 3,
                            Rating = 4,
                            CoolerType = "Air",
                            Height = 155,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "NZXT Kraken Z63 RGB 280mm",
                            Description = "The NH-D15 chromax.black is an all-black version of Noctua’s award-winning" +
                                          "flagship model NH-D15 premium-quality quiet Cpu cooler. Thanks to the same" +
                                          "proven dual-tower heatsink design and NF-A15 PWM fans, it stays true to" +
                                          "the NH-D15’s successful formula of rivalling the performance of all-in-one" +
                                          "water coolers while maintaining superb quietness of operation",
                            productOfficialWebsite = "https://nzxt.com/product/kraken-z63-rgb",
                            mainImage = "https://nzxt.com/assets/cms/34299/1631207832-kraken-z63-rgb-white-keyshot.png?auto=format&fit=crop&h=1000&w=1000",
                            modelNumber = "RL-KRZ63-RW",
                            Price = 300.92M,
                            Brand = "NZXT",
                            Warranty = 3,
                            Rating = 5,
                            CoolerType = "Water",
                            Height = 350,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "Fractal Design Celsius+ S36 Prisma",
                            Description = "Celsius+ takes AIO water cooling to a new level with an ARGB-accented" + 
                                          " pump face, a fully redesigned block and an upgraded on-radiator PWM " + 
                                          "fan hub with ARGB support. Compatible with most common Intel/AMD sockets," + 
                                          " including LGA1700 and AM5",
                            productOfficialWebsite = "https://www.fractal-design.com/products/water-cooling/celsius/celsius-plus-s36-prisma/",
                            mainImage = "https://www.fractal-design.com/app/uploads/2020/04/Celsius_S36_RGB_LGA_1700_Ready_2560px-540x540.jpg",
                            modelNumber = "FD-W-2-S3602",
                            Price = 255.00M,
                            Brand = "Fractal Design",
                            Warranty = 3,
                            Rating = 4,
                            CoolerType = "Water",
                            Height = 400,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
                        },
                        new ()
                        {
                            Name = "Thermaltake Water 3.0 360 ARGB Sync",
                            Description = "All-in-one 360mm liquid cooler with PWM fans that supports 5V RGB" + 
                                          " capable motherboards",
                            productOfficialWebsite = "https://www.thermaltake.com/water-3-0-360-argb-sync.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/6af153fd0a0c509bdfcdfb60a394dd9c/db/imgs/pdt/angle/CL-W234-PL12SW-A_0a0500231eaf4f1f8b4b30b685b2cb22.jpg",
                            modelNumber = "CL-W234-PL12SW-A",
                            Price = 141.92M,
                            Brand = "Thermaltake",
                            Warranty = 4,
                            Rating = 5,
                            CoolerType = "Water",
                            Height = 360,
                            CpuType = "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700 " +
                                      "(included since Q4 2021, older coolers require NM-i17xx-MP83), " +
                                      "LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4, AM5"
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
                        },
                        new()
                        {
                            Name = "Kingston Data Center SSD DC500M 1.92TB",
                            Description = "Kingston’s Data Center 500 (DC500R / DC500M) Series of solid-state drives" + 
                                          " are high performance 6Gbps SATA SSDs using the latest 3D TLC NAND, designed" + 
                                          " for Read Centric and Mixed-Use server workloads. ",
                            productOfficialWebsite = "https://www.kingston.com/en/ssd/dc500-data-center-solid-state-drive",
                            mainImage = "https://media.kingston.com/kingston/hero/ktc-hero-ssd-dc500r-dc500m-lg.jpg",
                            modelNumber = "DC500R / DC500M",
                            Price = 350.08M,
                            Brand = "Kingston",
                            Warranty = 3,
                            Rating = 5,
                            ConnectionType = "SATA3",
                            Capacity = 1920,
                            MaxWrite = 520,
                            MaxRead = 555
                        },
                        new()
                        {
                            Name = "Samsung 870 QVO SSD",
                            Description = "More storage space, more options The 870 QVO is Samsung's latest" + 
                                          " 2nd generation QLC SSD and provides the largest available storage" + 
                                          " in its category, up to 8 TB. It offers an incredible step forward" + 
                                          " for everyday PC users who want to equip their desktop PC or laptop" + 
                                          " with the most storage available on the market without sacrificing performance",
                            productOfficialWebsite = "https://www.samsung.com/en/memory-storage/sata-ssd/ssd-870-qvo-sata-3-2-5-inch-2tb-mz-77q2t0bw/",
                            mainImage = "https://images.samsung.com/is/image/samsung/hu-870-qvo-sata-3-2-5-ssd-mz-77q2t0bw-frontblack-265553696?$360_288_PNG$",
                            modelNumber = "S870QVO",
                            Price = 200.68M,
                            Brand = "Samsung",
                            Warranty = 3,
                            Rating = 4,
                            ConnectionType = "SATA3",
                            Capacity = 2000,
                            MaxWrite = 530,
                            MaxRead = 560
                        },
                        new()
                        {
                            Name = "Crucial MX500 1TB SATA3 2,5 SSD",
                            Description = "Fly through everything you do Start your system in seconds, load files almost" + 
                                          " instantly, and accelerate the most demanding applications with the Crucial" + 
                                          " MX500. Our dynamic write acceleration technology uses an adaptable pool of " + 
                                          "high-speed single-level cell flash memory to generate blistering speeds.",
                            productOfficialWebsite = "https://www.crucial.com/ssd/mx500/ct1000mx500ssd1/ct11514117?gclid=Cj0KCQiA_bieBhDSARIsADU4zLcTPkP0QkIm3GTIUCRTvFKlIt5pTOqyLHko26UcedFkLu5hQbCS2AwaAuo3EALw_wcB&pr_rd_page=4&ef_id=Cj0KCQiA_bieBhDSARIsADU4zLcTPkP0QkIm3GTIUCRTvFKlIt5pTOqyLHko26UcedFkLu5hQbCS2AwaAuo3EALw_wcB:G:s&gclsrc=aw.ds#res-benefits",
                            mainImage = "https://content.crucial.com/content/dam/crucial/ssd-products/mx500/images/product/crucial-mx500-2-5inch-product-front-image.psd.transform/medium-png/image.png",
                            modelNumber = "CT1000MX500SSD1",
                            Price = 85.00M,
                            Brand = "Crucial",
                            Warranty = 3,
                            Rating = 4,
                            ConnectionType = "SATA3",
                            Capacity = 1000,
                            MaxWrite = 510,
                            MaxRead = 560
                        },
                        new()
                        {
                            Name = "Corsair Force MP600 series Gen4 NVMe PCIe M.2 SSD 2TB",
                            Description = "The CORSAIR Force MP600 Gen4 PCIe x4 NVMe M.2 SSD provides extreme storage performance," + 
                                          " using Gen4 PCIe technology to achieve blazing fast sequential read speeds of up" + 
                                          " to 4,950MB/s.",
                            productOfficialWebsite = "https://www.corsair.com/ww/en/Categories/Products/Storage/M-2-SSDs/Force-Series%E2%84%A2-Gen-4-PCIe-NVMe-M-2-SSD/p/CSSD-F2000GBMP600",
                            mainImage = "https://www.corsair.com/medias/sys_master/images/images/hde/hc9/9251964452894/-CSSD-F2000GBMP600-Gallery-MP600-01.png",
                            modelNumber = "CSSD-F2000GBMP600",
                            Price = 160.68M,
                            Brand = "Corsair",
                            Warranty = 3,
                            Rating = 5,
                            ConnectionType = "M.2",
                            Capacity = 2000,
                            MaxWrite = 4250,
                            MaxRead = 4950
                        },
                        new()
                        {
                            Name = "GIGABYTE SSD M.2 2280 NVMe 2TB AORUS",
                            Description = "AORUS Gen4 7000s SSD meets the required performance and dimensions of PS5 M.2" + 
                                          " SSD. According to the expansion requirements  Adopting by Aluminum Heat " + 
                                          "Spreaders with Nanocarbon Coating, AORUS Gen4 7000s SSD improves thermal " + 
                                          "dissipation and helps to prevent throttling.of PS5, SSD Sequential read " + 
                                          "speed needs to be up to 5,500MB/s. However, AORUS Gen4 7000s SSD delivers " + 
                                          "blazing speeds: up to 7,000 MB/s for sequential read, which is better than " + 
                                          "regular Gen4 SSDs.",
                            productOfficialWebsite = "https://www.gigabyte.com/eu/SSD/AORUS-Gen4-7000s-SSD-2TB#kf",
                            mainImage = "https://1.pcx.hu/pcx_upload/termek-kepek/38/b/382090_1.jpg",
                            modelNumber = "GP-AG70S2TB-P",
                            Price = 110.68M,
                            Brand = "GIGABYTE",
                            Warranty = 3,
                            Rating = 5,
                            ConnectionType = "M.2",
                            Capacity = 2000,
                            MaxWrite = 6850,
                            MaxRead = 7000
                        },
                        new()
                        {
                            Name = "Silicon Power UD70, 2048GB, PCIe Gen3x4 & NVMe, SSD ",
                            Description = "With 3D QLC NAND storage technology, the UD70 PCIe Gen 3x4 incorporates a much" + 
                                          " higher memory cell density, allowing for greater storage capacity on a smaller" + 
                                          " footprint – up to 2TB. Plus, NVMe 1.3 support, read speeds up to 3,400MB/s, and" + 
                                          " write speeds up to 3,000MB/s make this M.2 2280 SSD a force to be reckoned with." + 
                                          " As an overall cost-efficient option, the UD70 is truly an all-around performer" + 
                                          " that's perfect for DIY system builders, casual gamers and video editors, and simply" + 
                                          " those who are looking to upgrade their PC",
                            productOfficialWebsite = "https://www.silicon-power.com/web/us/product-UD70",
                            mainImage = "https://www.silicon-power.com/images/product/apple/495/SP4TB.jpg",
                            modelNumber = "SP02KGBP34UD7005",
                            Price = 75.68M,
                            Brand = "Silicon Power",
                            Warranty = 3,
                            Rating = 4,
                            ConnectionType = "M.2",
                            Capacity = 2048,
                            MaxWrite = 3000,
                            MaxRead = 3400
                        },
                        new()
                        {
                            Name = "Team Group 2TB SSD M.2 meghajtó Cardea A440",
                            Description = "Enjoy the lightning speed of the PCIe Gen4 x4, Featuring two patented" + 
                                          " heat sinks, Effective cooling—flexible installation, Supports the latest" + 
                                          " NVMe 1.4 standard, ",
                            productOfficialWebsite = "https://www.teamgroupinc.com/en/product/cardea-a440",
                            mainImage = "https://www.teamgroupinc.com/en/upload/product_color_m/2526d25210b27439d4c1e0df65aea75a.jpg",
                            modelNumber = "TM8FPZ002T0C327",
                            Price = 80.00M,
                            Brand = "Team Group",
                            Warranty = 3,
                            Rating = 5,
                            ConnectionType = "M.2",
                            Capacity = 2000,
                            MaxWrite = 6900,
                            MaxRead = 7000
                        },
                        new()
                        {
                            Name = "BIOSTAR 1TB M700 NVMe 1.3 ",
                            Description = "M700 series 1TB SSD, PCI-Express Gen3x4 interface, Support NVMe v1.3",
                            productOfficialWebsite = "https://www.biostar.com.tw/app/en/ssd/introduction.php?S_ID=32",
                            mainImage = "https://www.biostar.com.tw/upload/Ssd/s20191128.png",
                            modelNumber = "SS263PME3T",
                            Price = 106.68M,
                            Brand = "BIOSTAR",
                            Warranty = 3,
                            Rating = 4,
                            ConnectionType = "M.2",
                            Capacity = 1000,
                            MaxWrite = 1650,
                            MaxRead = 2000
                        },
                        new()
                        {
                            Name = "SILICON POWER XD80 PCIe Gen 3x4 NVMe M.2 2280 3400/3000MB/s 1T ",
                            Description = "Featuring SLC Caching and DRAM Cache Buffer, the XD80 peels" + 
                                          " rubber with blazing read/write speeds up to 3,400/3,000MB/s, " + 
                                          "respectively. Its high-speed PCIe Gen3x4 interface leaves traditional" + 
                                          " SATA III SSDs behind in the dust, giving hardcore gamers the competitive" + 
                                          " edge they need to secure the win.",
                            productOfficialWebsite = "https://www.biostar.com.tw/app/en/ssd/introduction.php?S_ID=32",
                            mainImage = "https://www.silicon-power.com/images/product/apple/517/XD80_F_1024.jpg",
                            modelNumber = "SP001TBP34XD8005",
                            Price = 88.68M,
                            Brand = "SILICON POWER",
                            Warranty = 3,
                            Rating = 5,
                            ConnectionType = "M.2",
                            Capacity = 1000,
                            MaxWrite = 3000,
                            MaxRead = 3400
                        },
                        new()
                        {
                            Name = "GIGABYTE SSD M.2 2280 NVMe 500GB AORUS ",
                            Description = "Form Factor: M.2 2280 Interface: PCI-Express 4.0 x4, NVMe 1.3 " + 
                                          "Total Capacity: 500GB* Sequential Read Speed : up to 5000 MB/s**" + 
                                          " Sequential Write speed : up to 2500 MB/s**",
                            productOfficialWebsite = "https://www.gigabyte.com/eu/SSD/AORUS-Gen4-SSD-500GB#kf",
                            mainImage = "https://static.gigabyte.com/StaticFile/Image/Global/91e66370ec5ef51afa3354cf2c51b8e9/Product/25698/png",
                            modelNumber = "GP-AG4500G",
                            Price = 80.68M,
                            Brand = "GIGABYTE",
                            Warranty = 5,
                            Rating = 5,
                            ConnectionType = "M.2",
                            Capacity = 500,
                            MaxWrite = 2500,
                            MaxRead = 5000
                        },

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
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForceRTX3090Ti",
                            VramSize = 24,
                            VramType = "GDDR6",
                            RequiredPSU = 750,
                            Length = 317
                        },
                        new()
                        {
                            Name = "GIGABYTE RTX 4090 Gaming OC 24G 24GB GDDR6X",
                            Description = "NVIDIA Ada Lovelace Streaming Multiprocessors: Up to 2x performance and power efficiency," +
                                          " 4th Generation Tensor Cores: Up to 4x performance with DLSS 3 vs. brute-force rendering, " +
                                          "3rd Generation RT Cores: Up to 2X ray tracing performance, Powered by GeForce RTX® 4090," +
                                          " Integrated with 24GB GDDR6X 384-bit memory interface, WINDFORCE cooling system, RGB Fusion," +
                                          " Dual BIOS, Protection metal back plate, Anti-sag bracket",
                            productOfficialWebsite = "https://www.gigabyte.com/Graphics-Card/GV-N4090GAMING-OC-24GD#kf",
                            mainImage = "https://static.gigabyte.com/StaticFile/Image/Global/eb312818c4c56daca93f4c5cdd80ceca/Product/32030/png/450",
                            modelNumber = "GV-N4090GAMING OC-24GD",
                            Price = 2660.00M,
                            Brand = "GIGABYTE",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX™ 4090",
                            VramSize = 24,
                            VramType = "GDDR6X",
                            RequiredPSU = 1000,
                            Length = 340
                        },
                        new()
                        {
                            Name = "MSI nVIDIA RTX 4080 SUPRIM X 16GB DDR6X RTX 4080 16GB",
                            Description = "Ascend to a superior experience with SUPRIM. See, hear, and feel a profoundly elevated" +
                                          " graphics card built with high-quality materials and assembled with enthusiast features",
                            productOfficialWebsite = "https://www.msi.com/Graphics-Card/GeForce-RTX-4080-16GB-SUPRIM-X/Specification",
                            mainImage = "https://storage-asset.msi.com/global/picture/product/product_1668072619aaa562df9dd1ada3ffebd483276bac5c.png",
                            modelNumber = "MSISUPRIMX",
                            Price = 1660.98M,
                            Brand = "MSI",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX™ 4080",
                            VramSize = 16,
                            VramType = "GDDR6X",
                            RequiredPSU = 850,
                            Length = 340
                        },
                        new()
                        {
                            Name = "ASUS ROG Strix RTX 4070 Ti 12GB GDDR6X",
                            Description = "Powered by NVIDIA DLSS3, ultra-efficient Ada Lovelace arch, and full ray tracing. 4th" +
                                          " Generation Tensor Cores: Up to 4x performance with DLSS 3 vs. brute-force rendering3rd" +
                                          " Generation RT Cores: Up to 2X ray tracing performance, Axial-tech fans scaled up for 31%" +
                                          " more airflow, 3.15-slot design: massive fin array optimized for airflow from the three" +
                                          " Axial-tech fans , Diecast shroud, frame, and backplate add rigidity and are vented to" +
                                          " further maximize airflow and heat dissipation , Digital power control with high-current" +
                                          " power stages and 15K capacitors to fuel maximum performance, Auto-Extreme precision" +
                                          " automated manufacturing for higher reliability , GPU Tweak III software provides intuitive" +
                                          " performance tweaking, thermal controls, and system monitoring",
                            productOfficialWebsite = "https://www.msi.com/Graphics-Card/GeForce-RTX-4080-16GB-SUPRIM-X/Specification",
                            mainImage = "https://dlcdnwebimgs.asus.com/gain/ADA66D58-0735-4697-BA43-1E5BCEEBC43B/w717/h525",
                            modelNumber = "ROG-STRIX-RTX4070TI-12G GAMING",
                            Price = 1400.98M,
                            Brand = "ASUS",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX™ 4070",
                            VramSize = 16,
                            VramType = "GDDR6X",
                            RequiredPSU = 750,
                            Length = 340
                        },
                        new()
                        {
                            Name = "ASRock RX 7900 XTX Phantom Gaming OC 24GB GDDR6",
                            Description = "PRODUCT BRIEF: Clock: GPU / Memory: Boost Clock*: Up to 2615MHz / 20Gbps," +
                                          " Game Clock**: 2455MHz / 20Gbps,Key Specifications: AMD Radeon™ RX 7900 XTX GPU," +
                                          " 24GB GDDR6 on 384-Bit Memory Bus, 96 AMD RDNA™ 3 Compute Units (With Rt+Ai Accelerators)," +
                                          " 96MB AMD Infinity Cache™ Technology, PCI® Express 4.0 Support, 3 x 8-pin Power Connectors," +
                                          " 3 x DisplayPort™ 2.1 / 1 x HDMI™ 2.1 Key Features: Polychrome SYNC, Phantom Gaming 3X Cooling System," +
                                          " Striped Ring Fan, Reinforced Metal Frame, Stylish Metal Backplate, 0dB Silent Cooling, Super Alloy",
                            productOfficialWebsite = "https://pg.asrock.com/Graphics-Card/AMD/Radeon%20RX%207900%20XTX%20Phantom%20Gaming%2024GB%20OC/index.asp",
                            mainImage = "https://pg.asrock.com/Graphics-Card/photo/Radeon%20RX%207900%20XTX%20Phantom%20Gaming%2024GB%20OC(M1).png",
                            modelNumber = "RX7900XTX PG 24GO",
                            Price = 1450.98M,
                            Brand = "ASRock",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "RX 7900 XTX",
                            VramSize = 24,
                            VramType = "GDDR6X",
                            RequiredPSU = 1000,
                            Length = 330
                        },
                        new()
                        {
                            Name = "Gigabyte GeForce RTX 3080 Gaming OC Waterforce WB 10GB GDDR6X 320-bit",
                            Description = "NVIDIA Ampere Streaming Multiprocessors, 2nd Generation RT Cores, 3rd Generation, Tensor Cores," +
                                          " Powered by GeForce RTX™ 3080, Integrated with 10GB GDDR6X 320-bit, memory interface, WATERFORCE" +
                                          " Water Block cooling system, RGB Fusion 2.0, Protection metal back plate, 4 Years Warranty" +
                                          " (Online registration required), LHR (Lite Hash Rate) version",
                            productOfficialWebsite = "https://www.gigabyte.com/eu/Graphics-Card/GV-N3080GAMINGOC-WB-10GD-rev-20#kf",
                            mainImage = "https://www.gigabyte.com/FileUpload/Global/KeyFeature/1905/innergigabyteimages/kf-img.png",
                            modelNumber = "GV-N3080GAMINGOC WB-10GD",
                            Price = 1250.98M,
                            Brand = "GIGABYTE",
                            Warranty = 4,
                            Rating = 5,
                            VideoChipset = "GeForce RTX™ 3080",
                            VramSize = 10,
                            VramType = "GDDR6X",
                            RequiredPSU = 750,
                            Length = 310
                        },
                        new()
                        {
                            Name = "ASUS GeForce RTX 3070 Ti 8GB OC GDDR6X 256bit",
                            Description = "ROG Strix GeForce RTX™ 3070 Ti OC Edition 8GB GDDR6X buffed-up design with chart-topping thermal" +
                                          " performance.NVIDIA Ampere Streaming Multiprocessors: The building blocks for the world’s fastest," +
                                          " most efficient GPUs, the all-new Ampere SM brings 2X the FP32 throughput and improved power efficiency." +
                                          " 2nd Generation RT Cores: Experience 2X the throughput of 1st gen RT Cores, plus concurrent RT and" +
                                          " shading for a whole new level of ray tracing performance. 3rd Generation Tensor Cores: Get up to 2X" +
                                          " the throughput with structural sparsity and advanced AI algorithms such as DLSS. These cores deliver" +
                                          " a massive boost in game performance and all-new AI capabilities. OC edition: Boost clock 1875 MHz" +
                                          " (OC mode)/ 1845 MHz (Gaming mode) Axial-tech Fan Design has been tuned up with more fan blades and" +
                                          " a reversed rotational direction for the center fan. 2.9-slot design expands cooling surface area" +
                                          " compared to last gen for more thermal headroom than ever before. Super Alloy Power II includes premium" +
                                          " alloy chokes, solid polymer capacitors, and an array of high-current power stages. GPU Tweak II provides" +
                                          " intuitive performance tweaking, thermal controls, and system monitoring",
                            productOfficialWebsite = "https://rog.asus.com/graphics-cards/graphics-cards/rog-strix/rog-strix-rtx3070ti-o8g-gaming-model/",
                            mainImage = "https://dlcdnwebimgs.asus.com/gain/FC322AD0-2B5C-4CDD-857C-484F9D2C30A3/w717/h525",
                            modelNumber = "ROG-STRIX-RTX3070TI-O8G-GAMING",
                            Price = 980.00M,
                            Brand = "ASUS",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX™ 3070 Ti",
                            VramSize = 8,
                            VramType = "GDDR6X",
                            RequiredPSU = 750,
                            Length = 320
                        },
                        new()
                        {
                            Name = "MSI Geforce RTX 3060 Ti Ventus 3X 8GB",
                            Description = "VENTUS brings a performance-focused design that maintains the essentials to accomplish any task at" +
                                          " hand. A capable triple fan arrangement laid into a rigid industrial design lets this sharp looking" +
                                          " graphics card fit into any build.",
                            productOfficialWebsite = "https://www.msi.com/Graphics-Card/GeForce-RTX-3060-Ti-VENTUS-3X-8G-OC-LHR",
                            mainImage = "https://storage-asset.msi.com/global/picture/image/feature/vga/ventus/3060Ti-ventus-3x/kv-xs.jpg",
                            modelNumber = "RTX3060TiVENTUS3XLHR",
                            Price = 960.98M,
                            Brand = "MSI",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX™ 3060 Ti",
                            VramSize = 8,
                            VramType = "GDDR6X",
                            RequiredPSU = 600,
                            Length = 310
                        },
                        new()
                        {
                            Name = "Gainward GeForce RTX 3070 Ti Phoenix 8GB GDDR6X",
                            Description = "Reinforced Fan Blade, ARGB Lighting, U-Type Heat Pipe, ZERO RPM FAN, NVIDIA DLSS, NVIDIA REFLEX" +
                                          ", DIRECTX 12 ULTIMATE, GEFORCE EXPERIENCE™, GAME READY DRIVERS, NVIDIA SHADOWPLAY™, NVIDIA ANSEL," +
                                          " NVIDIA STUDIO, VIRTUAL REALITY, NVIDIA G-SYNC®, DIRECTX 12/DXR, BROADCAST LIKE A PRO, 4K",
                            productOfficialWebsite = "https://www.gainward.com/main/vgapro.php?id=1130",
                            mainImage = "https://www.gainward.com/main/product/vga/pro/p01130/p01130_pic2_67860b5a67b82627.png",
                            modelNumber = "471056224-2713",
                            Price = 825.00M,
                            Brand = "Gainward",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX 3070 Ti",
                            VramSize = 8,
                            VramType = "GDDR6X",
                            RequiredPSU = 600,
                            Length = 300
                        },
                        new()
                        {
                            Name = "Zotac GAMING GeForce RTX 3070 Twin Edge LHR nVidia 8GB GDDR6 256bit PCIe ZT-A30700E-10PLHR",
                            Description = "Get Amplified with the ZOTAC GAMING GeForce RTX™ 30 Series based on the NVIDIA Ampere architecture." +
                                          " Built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and high-speed GDDR6" +
                                          " memory, the ZOTAC GAMING GeForce RTX 3070 Twin Edge OC LHR gives rise to amplified gaming with high fidelity.",
                            productOfficialWebsite = "https://www.zotac.com/us/product/graphics_card/zotac-gaming-geforce-rtx-3070-twin-edge-oc-lhr",
                            mainImage = "https://www.zotac.com/download/files/styles/w1024/public/product_gallery/graphics_cards/zt-a30700h-10plhr-image01.jpg?itok=WnyQyXX3",
                            modelNumber = "ZT-A30900J-10P",
                            Price = 750.98M,
                            Brand = "Zotac",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce RTX 3070",
                            VramSize = 8,
                            VramType = "GDDR6X",
                            RequiredPSU = 600,
                            Length = 240
                        },
                        new()
                        {
                            Name = "MSI PCI-Ex16x nVIDIA GT 710 2GB DDR3 GT 710 2GD3H LP",
                            Description = "HDMI x 1(Supports 4K@30Hz as specified in HDMI 1.4) Dual-link DVI-D x 1 D-Sub x 1",
                            productOfficialWebsite = "https://www.msi.com/Graphics-Card/GT-710-2GD3H-LP/Specification",
                            mainImage = "https://asset.msi.com/resize/image/global/product/product_5_20180416143557_5ad4444d05e19.png62405b38c58fe0f07fcef2367d8a9ba1/1024.png",
                            modelNumber = "ZT-A30900J-10P",
                            Price = 65.00M,
                            Brand = "MSI",
                            Warranty = 3,
                            Rating = 5,
                            VideoChipset = "GeForce® GT 710",
                            VramSize = 2,
                            VramType = "GDDR3",
                            RequiredPSU = 400,
                            Length = 150
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
                                          "Supports Full Spike Protection, ASRock Live UpdateProduct & APP Shop",
                            productOfficialWebsite = "https://www.asrock.com/mb/Intel/H310CM-DVS/index.asp",
                            mainImage = "https://www.asrock.com/mb/photo/H310CM-DVS(L1).png",
                            modelNumber = "90-MXB8K0-A0UAYZ",
                            Price = 59.85M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
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
                        },
                        new()
                        {
                            Name = "ASUS ROG MAXIMUS XIII EXTREME GLACIAL",
                            Description = "Intel® Z590 EATX motherboard with 18+2 power stages, integrated full-coverage" +
                                          " EK water block, five M.2 slots, USB 3.2 Gen 2x2 front-panel connector, USB 3.2" +
                                          " Gen 2 front-panel connector, dual Thunderbolt™ 4, Marvell® AQtion 10 Gb Ethernet," +
                                          " Intel® 2.5 Gb Ethernet, PCIe® 4.0, onboard WiFi 6E (802.11ax) and Aura Sync RGB lighting",
                            productOfficialWebsite = "https://rog.asus.com/hu/motherboards/rog-maximus/rog-maximus-xiii-extreme-glacial-model/",
                            mainImage = "https://dlcdnwebimgs.asus.com/gain/54B2AC93-9147-4A89-91B2-9162B488A2B1/w717/h525",
                            modelNumber = "90MB1730-M0EAY0",
                            Price = 1300.85M,
                            Brand = "ASUS",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "Z590",
                            Size = SizeStandard.EATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 5400,
                            MemorySockets = 4,
                            XMP = true,
                            MaxMemory = 128,
                            CForSLISupport = "true",
                            Bluetooth = "False",
                            Lighting = false,
                            Windows11Support = true,
                            Wifi = "WiFi 6E (802.11ax)",
                            LANPort = "10/100/1000/2500 Mb/s",
                            LanportsNumber = 2,
                            PCIe16x = 2,
                            SATA3 = 6,
                            M2 = 5,
                            USB2 = 4,
                            USB3 = 12,
                            USB31 = 4,
                            USBC = 2
                        },
                        new()
                        {
                            Name = "Gigabyte Intel Z590 AORUS XTREME",
                            Description = "Showcasing a state-of-the-art design, excellent functionality, an impressive thermal design," +
                                          " next generation connectivity, a Hi-Fi level audio system, and AORUS aesthetics," +
                                          " the flagship Z590 AORUS XTREME motherboard dominates the competition",
                            productOfficialWebsite = "https://www.gigabyte.com/Motherboard/Z590-AORUS-XTREME-rev-10#kf",
                            mainImage = "https://www.gigabyte.com/FileUpload/Global/KeyFeature/1723/innergigabyteimages/motherboard.png",
                            modelNumber = "Z590AORUSXTREME",
                            Price = 650.85M,
                            Brand = "ASUS",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "Z590",
                            Size = SizeStandard.EATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 5400,
                            MemorySockets = 4,
                            XMP = true,
                            MaxMemory = 128,
                            CForSLISupport = "supported",
                            Bluetooth = null,
                            Lighting = true,
                            Windows11Support = true,
                            Wifi = "WiFi 6E (802.11ax)",
                            LANPort = "10/100/1000/2500 Mb/s",
                            LanportsNumber = 2,
                            PCIe16x = 3,
                            SATA3 = 6,
                            M2 = 2,
                            USB2 = 4,
                            USB3 = 0,
                            USB31 = 8,
                            USBC = 2
                        },
                        new()
                        {
                            Name = "Msi MPG Z490 GAMING PLUS",
                            Description = "The MPG series brings out the best in gamers by allowing full expression" +
                                          " in color with advanced RGB lighting control and synchronization. " +
                                          "Experiment on another level of personalization with a front LED strip" +
                                          " that provides convenient in-game and real time notifications. With the" +
                                          " MPG series, transform your equipment into the center of attention" +
                                          " and top leaderboards in style",
                            productOfficialWebsite = "https://www.msi.com/Motherboard/MPG-Z490-GAMING-PLUS",
                            mainImage = "https://storage-asset.msi.com/global/picture/features/MB/Gaming/Z490/GamingPlus/gaming-plus-story_img.png",
                            modelNumber = "MPGZ490GamingPlus",
                            Price = 230.00M,
                            Brand = "MSI",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "Z490",
                            Size = SizeStandard.EATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 4800,
                            MemorySockets = 4,
                            XMP = true,
                            MaxMemory = 128,
                            CForSLISupport = "not supported",
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = true,
                            Wifi = "WiFi 6E (802.11ax)",
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 2,
                            PCIe16x = 2,
                            SATA3 = 6,
                            M2 = 2,
                            USB2 = 2,
                            USB3 = 0,
                            USB31 = 3,
                            USBC = 0
                        },
                        new()
                        {
                            Name = "BIOSTAR NEWSILVERZ490ATX4-dimm",
                            Description = "Supports 10th/ 11th Generation Intel Core™ Processor, Intel Z490" +
                                          " single chip architecture, Supports 4-DIMM DDR4- 2133/ 2400/ 3200(OC)/3600(OC)/" +
                                          " 3800(OC)/ 4000(OC)/ 4400+(OC) up to 128 GB Memory, Supports PCIe M.2 (32Gb/s)," +
                                          " Supports Intel Optane Technology, Supports HDMI 4K resolution, Supports GbE LAN," +
                                          " Supports USB 3.2 Gen1, Supports WiFi 6 (No Wifi 6 card included)2666/ 2800/ 2933",
                            productOfficialWebsite = "https://www.biostar.com.tw/app/en/mb/introduction.php?S_ID=990#specification",
                            mainImage = "https://www.biostar.com.tw/upload/Motherboard/b20200807_1.png",
                            modelNumber = "Z490A-SILVER",
                            Price = 185.00M,
                            Brand = "BIOSTAR",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "Z490",
                            Size = SizeStandard.EATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 4400,
                            MemorySockets = 4,
                            XMP = true,
                            MaxMemory = 128,
                            CForSLISupport = "not supported",
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = "WiFi 6E (802.11ac)",
                            LANPort = "10/100/1000/2500 Mb/s",
                            LanportsNumber = 2,
                            PCIe16x = 2,
                            SATA3 = 6,
                            M2 = 2,
                            USB2 = 6,
                            USB3 = 0,
                            USB31 = 6,
                            USBC = 0
                        },
                        new()
                        {
                            Name = "ASUS TUF GAMING B560M-PLUS Intel B560 LGA1200 mATX",
                            Description = "Supports 9th and 8th Gen Intel® Core™ Processors (Socket 1151)" +
                                          "Supports DDR4 2666 1 PCIe 3.0 x16, 1 PCIe 2.0 x1 " +
                                          "Graphics Output Options: DVI-D, D-Sub " +
                                          "7.1 CH HD Audio (Realtek ALC887/897 Audio Codec) " +
                                          "4 SATA3 4 USB 3.1 Gen1 (2 Front, 2 Rear) " +
                                          "Supports Full Spike Protection, ASRock Live UpdateProduct & APP Shop",
                            productOfficialWebsite = "https://www.asus.com/hu/motherboards-components/motherboards/tuf-gaming/tuf-gaming-b560m-plus/techspec/",
                            mainImage = "https://dlcdnwebimgs.asus.com/gain/117af48e-0454-452f-9ee8-d9d22bb8dd1f/w328",
                            modelNumber = "TUFGAMINGB560M-PLUS",
                            Price = 185.85M,
                            Brand = "ASUS",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "B560",
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 5000,
                            MemorySockets = 4,
                            XMP = false,
                            MaxMemory = 128,
                            CForSLISupport = "not supported",
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = "WiFi 6E (802.11ac)",
                            LANPort = "10/100/1000/2500 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 2,
                            SATA3 = 6,
                            M2 = 2,
                            USB2 = 6,
                            USB3 = 0,
                            USB31 = 3,
                            USBC = 4
                        },
                        new()
                        {
                            Name = "ASRock s1200 H510 Pro BTC+ H510 PRO BTC+",
                            Description = "Supports 10th Gen Intel® Core™ Processors and 11th Gen Intel® ," +
                                          " Core™ Processors, Supports DDR4 3200MHz, Graphics Output: HDMI, 6 " +
                                          "PCIe 3.0 x16, 1 Mining Port (M_Port1 at x1), 1 SATA3, 1 M.2 (SATA3)," +
                                          " 2 Rear USB 3.1 Gen1 Type-A, 4 USB 2.0 Type-A (2 Rear, 2 Front), " +
                                          "Intel® Gigabit LAN, 2 Extra 24-pin ATX Power Connector, Onboard " +
                                          "Power On / Reset Button, Fully Independent Power Rail",
                            productOfficialWebsite = "https://www.asrock.com/MB/Intel/H510%20Pro%20BTC+/index.hu.asp#Specification",
                            mainImage = "https://3.pcx.hu/pcx_upload/termek-kepek/46/m/469659_2.jpg",
                            modelNumber = "90-MXB8K0-A0UAYZ",
                            Price = 100.85M,
                            Brand = "Intel",
                            Warranty = 0,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "H510",
                            Size = SizeStandard.EATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 3200,
                            MemorySockets = 1,
                            XMP = false,
                            MaxMemory = 32,
                            CForSLISupport = null,
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = null,
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 6,
                            SATA3 = 1,
                            M2 = 1,
                            USB2 = 2,
                            USB3 = 0,
                            USB31 = 2,
                            USBC = 0
                        },
                        new()
                        {
                            Name = "BIOSTAR H410 mATXHDMI H410MH S2",
                            Description = "Supports 10th Generation Intel Core™ Processor, Intel H510 single chip architecture," +
                                          " Supports 2-DIMM DDR4- 2933/ 2666/ 2400/2133/ 1866 up to 64 GB Memory, Supports PCIe 3.0," +
                                          " Supports PCIe M.2 (32Gb/s), Supports USB 3.2 Gen1",
                            productOfficialWebsite = "https://www.biostar.com.tw/app/en/mb/introduction.php?S_ID=1036",
                            mainImage = "https://3.pcx.hu/pcx_upload/termek-kepek/46/m/464304_3.jpg",
                            modelNumber = "H410MHS2",
                            Price = 85.85M,
                            Brand = "BIOSTAR",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "H410",
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 2933,
                            MemorySockets = 2,
                            XMP = false,
                            MaxMemory = 64,
                            CForSLISupport = null,
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = null,
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 1,
                            SATA3 = 4,
                            M2 = 1,
                            USB2 = 6,
                            USB3 = 0,
                            USB31 = 4,
                            USBC = 0
                        },
                        new()
                        {
                            Name = "GIGABYTE Alaplap S1200 H410M H V2 INTEL H470, mATX",
                            Description = "Intel® Ultra Durable Motherboard with Intel® GbE LAN, Anti-Sulfur Resistor, Smart Fan 5",
                            productOfficialWebsite = "https://www.gigabyte.com/Motherboard/H410M-H-V2-rev-10/sp#sp",
                            mainImage = "https://3.pcx.hu/pcx_upload/termek-kepek/31/b/316858_1.jpg",
                            modelNumber = "H410MHV2",
                            Price = 59.85M,
                            Brand = "Intel",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "H410M",
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 2933,
                            MemorySockets = 2,
                            XMP = false,
                            MaxMemory = 64,
                            CForSLISupport = null,
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = null,
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 1,
                            SATA3 = 4,
                            M2 = 1,
                            USB2 = 6,
                            USB3 = 0,
                            USB31 = 4,
                            USBC = 0
                        },
                        new()
                        {
                            Name = "Asrock H510M-HDV R2.0",
                            Description = "Supports 10th Gen Intel® Core™ Processors and 11th Gen Intel® Core™ Processors, " +
                                          "Supports DDR4 3200MHz*, 1 x PCIe 4.0 x16, 1 x PCIe 3.0 x1, Graphics Output Options: HDMI," +
                                          " DVI-D, D-Sub, 7.1 CH HD Audio (Realtek ALC887/ 897 Audio Codec), 4 SATA3, 4 x USB 3.2 Gen1 (2 x Rear, 2 x Front)," +
                                          " Realtek Gigabit LAN",
                            productOfficialWebsite = "https://www.asrock.com/mb/Intel/H510M-HDV%20R2.0/index.asp",
                            mainImage = "https://www.asrock.com/mb/photo/H510M-HDV%20R2.0(L1).png",
                            modelNumber = "H510MHDVR20",
                            Price = 55.85M,
                            Brand = "ASRock",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "H510",
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 3200,
                            MemorySockets = 2,
                            XMP = false,
                            MaxMemory = 64,
                            CForSLISupport = null,
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = null,
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 1,
                            SATA3 = 4,
                            M2 = 0,
                            USB2 = 4,
                            USB3 = 0,
                            USB31 = 4,
                            USBC = 0
                        },
                        new()
                        {
                            Name = "MSI H410M-B Pro",
                            Description = "PRO series helps users work smarter by delivering an efficient and productive" +
                                          " experience. Featuring stable functionality and high-quality assembly, PRO series" +
                                          " motherboards provide not only optimized professional workflows but also less," +
                                          " troubleshooting and longevity",
                            productOfficialWebsite = "https://www.msi.com/Motherboard/PRO-H410M-B",
                            mainImage = "https://storage-asset.msi.com/global/picture/image/feature/mb/H410M-B-PRO/images/h410m-story.png",
                            modelNumber = "90-MXB8K0-A0UAYZ",
                            Price = 55.85M,
                            Brand = "MSI",
                            Warranty = 3,
                            Rating = 5,
                            Socket = "LGA1200",
                            Chipset = "H510",
                            Size = SizeStandard.MicroATX,
                            Igpu = null,
                            RAM = "DDR4",
                            Frequency = 3200,
                            MemorySockets = 2,
                            XMP = false,
                            MaxMemory = 64,
                            CForSLISupport = null,
                            Bluetooth = null,
                            Lighting = false,
                            Windows11Support = false,
                            Wifi = null,
                            LANPort = "10/100/1000 Mb/s",
                            LanportsNumber = 1,
                            PCIe16x = 1,
                            SATA3 = 4,
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
                        },
                        new()
                        {
                            Name = "Thermaltake DistroCase 350P  ATX",
                            Description = "The DistroCase™ 350P is a multi-functional and truly unique open frame mid" +
                                          " tower chassis. The body of the case is constructed with its own water loop," +
                                          " a D5 pump, and 48 LEDs that are compatible with TT RGB PLUS, NeonMaker Light" +
                                          " Editing, and Motherboard RGB Software",
                            productOfficialWebsite = "https://www.thermaltake.com/distrocasetm-350p-mid-tower-chassis.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/cc8b24283b13da6bc2ff91682c03b54b/d/i/distro_350p_1.jpg",
                            modelNumber = "CA-1Q8-00M1WN-00",
                            Price = 580.58M,
                            Brand = "Thermaltake ",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.ATX,
                            MaxCpuCoolerHeight = 130,
                            MaxGpuLength = 320
                        },
                        new()
                        {
                            Name = "Cooler Master COSMOS C700P Black Edition",
                            Description = "Highly Flexible Layout, Sleek & solid aluminum handles, RGB lighting control & sync up, " +
                                          "Dual-curved Tempered Glass Side Panel, ",
                            productOfficialWebsite = "https://www.coolermaster.com/catalog/legacy-products/cases/cosmos-c700p/",
                            mainImage = "https://files.coolermaster.com/product/cosmos-c700p/img/cosmos-c700p-sprite2-s.png",
                            modelNumber = "MCC-C700P-KG5N-S00",
                            Price = 410.58M,
                            Brand = "Cooler Master",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 198,
                            MaxGpuLength = 320
                        },
                        new()
                        {
                            Name = "RAIJINTEK NYX Pro Showcase E-ATX ",
                            Description = "Expensive",
                            productOfficialWebsite = "https://zalmanusa.com/products/z-machine-500-full-tower",
                            mainImage = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcaseking.hu%2Fuploads%2Fimages%2Fproducts%2FCAR%2FCART091.jpg&f=1&nofb=1&ipt=f139d8aa47dbeb3896f2117a171d2a3fb1026e326fe85c79b2546a43a67b80d9&ipo=images",
                            modelNumber = "0R20B00185",
                            Price = 400.58M,
                            Brand = "RAIJINTEK",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 75,
                            MaxGpuLength = 496
                        },
                        new()
                        {
                            Name = "Jonsbo TR03-G Showcase ATX",
                            Description = "Jonsbo TR03-G Showcase ATX Black Tempered Glass",
                            productOfficialWebsite = "https://www.jonsbo.com/en/products/tr03ablack.html",
                            mainImage = "https://www.jonsbo.com/Upfiles/Prod_X/202042268810.jpg",
                            modelNumber = "TR03-G BLACK",
                            Price = 305.58M,
                            Brand = "Jonsbo",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.ATX,
                            MaxCpuCoolerHeight = 175,
                            MaxGpuLength = 175
                        },
                        new()
                        {
                            Name = "Thermaltake AH T600 Snow EATX ",
                            Description = "The Thermaltake AH T600 Snow is a helicopter styled open frame full tower case which comes" +
                                          " with two 5mm tempered glass panels on left and right sides and can support motherboards up" +
                                          " to E-ATX (up to 10.5'' wide).",
                            productOfficialWebsite = "https://www.thermaltake.com/ah-t600-snow-full-tower-chassis.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/cc8b24283b13da6bc2ff91682c03b54b/a/h/ah_t600s_1.jpg",
                            modelNumber = "CA-1Q4-00M6WN-00",
                            Price = 260.58M,
                            Brand = "Thermaltake",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 195,
                            MaxGpuLength = 440
                        },
                        new()
                        {
                            Name = "Thermaltake Level 20 HT EATX",
                            Description = "Level 20 HT is an E-ATX full tower chassis that comes with four 4mm " +
                                          "thick tempered glass windows and two preinstalled 140mm standard fans up top",
                            productOfficialWebsite = "https://www.thermaltake.com/level-20-ht-chassis.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/6af153fd0a0c509bdfcdfb60a394dd9c/l/e/level20ht_3.jpg",
                            modelNumber = "CA-1P6-00F1WN-00",
                            Price = 230.58M,
                            Brand = "Thermaltake",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 260,
                            MaxGpuLength = 400
                        },
                        new()
                        {
                            Name = "Thermaltake Core P8 Tempered Glass  E-ATX ",
                            Description = "The Core P8 TG is a transformable E-ATX Full Tower Chassis that can be either used as a" +
                                          " closed or open styled case with Tt LCS Certification",
                            productOfficialWebsite = "https://www.thermaltake.com/core-p8-tempered-glass-full-tower-chassis.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/cc8b24283b13da6bc2ff91682c03b54b/c/o/core_p8_1.jpg",
                            modelNumber = "CA-1Q2-00M1WN-00",
                            Price = 210.58M,
                            Brand = "Thermaltake",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 180,
                            MaxGpuLength = 520
                        },
                        new()
                        {
                            Name = "Lian Li Odyssey X E-ATX ",
                            Description = "Sandblasted anodized finish aluminum full tower chassis " +
                                          "Three modes: Dynamic/ Dynamic-R (Rotate)/ Performance " +
                                          "Open airflow design with dual-side folding tempered glass " +
                                          "panels Supports up to EEB/E-ATX motherboard with 8 expansion " +
                                          "slots Ample water-cooling mounting space: Support up to 480mm " +
                                          "radiator, includes water pump mounting bracket Cable" +
                                          " management at ease",
                            productOfficialWebsite = "https://zalmanusa.com/products/z-machine-500-full-tower",
                            mainImage = "https://lian-li.com/wp-content/uploads/2021/06/tr-01-sh-a-00.jpg",
                            modelNumber = "TR-01A",
                            Price = 400.58M,
                            Brand = "Lian Li",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 180,
                            MaxGpuLength = 400
                        },
                        new()
                        {
                            Name = "Cooler Master MasterCase H500P Mesh White ARGB ",
                            Description = "Appearing in arctic white, the H Series embraces the golden rule of PC building: " +
                                          "to never stop upgrading. The MasterCase H500P Mesh White is no exception, now with" +
                                          " two pre-installed 200mm ARGB fans. Addressable RGB fans were previously only" +
                                          " available with the MasterCase H500M, the lineup’s premium flagship model",
                            productOfficialWebsite = "https://www.coolermaster.com/catalog/cases/mid-tower/mastercase-h500p-mesh-white-argb/",
                            mainImage = "https://cdn.coolermaster.com/media/assets/1052/h500p_mesh_white_argb_01_intro-imageleftorright.png",
                            modelNumber = "MCM-H500P-WGNN-S01",
                            Price = 200.58M,
                            Brand = "Cooler Master",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 195,
                            MaxGpuLength = 410
                        },
                        new()
                        {
                            Name = "Phanteks Eclipse P600S Black ",
                            Description = "Expensive",
                            productOfficialWebsite = "https://www.phanteks.com/Eclipse-P600s.html",
                            mainImage = "https://www.phanteks.com/images/product/Eclipse-P600s/Black/PH-EC600PSTG-1z.jpg",
                            modelNumber = "PH-EC600PSC_BK01",
                            Price = 200.58M,
                            Brand = "Phanteks",
                            Warranty = 3,
                            Rating = 5,
                            SizeCompatibility = SizeStandard.EATX,
                            MaxCpuCoolerHeight = 195,
                            MaxGpuLength = 435
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
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 1600,
                            Modular = true,
                            Classification = Classification.Platinum
                        },
                        new()
                        {
                            Name = "Thermaltake Toughpower iRGB PLUS ATX 1200W 80+ Titanium BOX",
                            Description = "80 PLUS Platinum certified fully modular analog PSU with 16.8million-color," +
                                          "18-LED RGB fan.",
                            productOfficialWebsite = "https://www.thermaltake.com/toughpower-pf1-argb-series-1200w.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/cc8b24283b13da6bc2ff91682c03b54b/1/2/1200.jpg",
                            modelNumber = "PS-TPI-1250DPCTEU-T",
                            Price = 430.00M,
                            Brand = "Thermaltake",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 1200,
                            Modular = true,
                            Classification = Classification.Titanium
                        },
                        new()
                        {
                            Name = "FSP 2000W 80+ Gold Cannon Pro",
                            Description = "With the upcoming 5G, IoT (internet of things), and blockchain technology’s rapid development," +
                                          " the demand for high wattage and stable power supply is an inevitable trend. CANNON PRO 2000W has" +
                                          " been designed to provide stable output for your system, it's also an upgrade series to provide you" +
                                          " safer and modern design with an IEC62368 safety certification. CANNON PRO 2000W features 18 sets of" +
                                          " PCI-E 6+2 Pin slots for satisfying the power-hungry device, and a 135mm fan with a unique layout" +
                                          " design for optimal cooling performance and keep the components in a longer lifespan. CANNON PRO 2000W" +
                                          " is your best choice for your monster PC build",
                            productOfficialWebsite = "https://www.fsplifestyle.com/en/product/cannonpro2000w.html",
                            mainImage = "https://www.fsplifestyle.com/upload/product/PIC21200000000009071.jpg",
                            modelNumber = "PPA20A0400",
                            Price = 350.39M,
                            Brand = "FSP",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 2000,
                            Modular = true,
                            Classification = Classification.Gold
                        },
                        new()
                        {
                            Name = "Cougar Polar 1050W",
                            Description = "To curb global warming, a PSU with higher efficiency means the longevity and" +
                                          " less energy goes to waste. The COUGAR Polar platinum efficiency series " +
                                          "protects the Earth and makes the best for the next generation",
                            productOfficialWebsite = "https://cougargaming.com/products/psus/polar/",
                            mainImage = "https://p1.akcdn.net/mid/1067609049.cougar-pr-1050-1050w.jpg",
                            modelNumber = "CGR PR-1050",
                            Price = 311.39M,
                            Brand = "Cougar",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 1050,
                            Modular = true,
                            Classification = Classification.Platinum
                        },
                        new()
                        {
                            Name = "Cooler Master 750W - XG750 PLUS PLATINUM",
                            Description = "Cooler Master keeps searching for uniqueness, creativity, and more. XG Plus Platinum is the first" +
                                          " Cooler Master in-house designed power supply, providing next-level efficiency, rigid design, and" +
                                          " sturdy performance to fulfill all your daily computing and gaming needs",
                            productOfficialWebsite = "https://www.coolermaster.com/uk/en-gb/catalog/power-supplies/xg-series/xg750-plus-platinum/",
                            mainImage = "https://cdn.coolermaster.com/media/3234/xg-plus-platinum-block9-img-900x900-1-imageleftorright.png",
                            modelNumber = "MPG-7501-AFBAP-XEU",
                            Price = 275.39M,
                            Brand = "Cooler Master",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 750,
                            Modular = true,
                            Classification = Classification.Platinum
                        },
                        new()
                        {
                            Name = "ZALMAN ZM850-ARX 80Plus Platinum",
                            Description = "80PLUS PLATINUM Modular cable management Power supply",
                            productOfficialWebsite = "https://www.zalman.com/US/Product/ProductDetail.do?productSeq=126",
                            mainImage = "https://www.zalman.com/cmm/fms/getImage.do?atchFileId=FILE_000000000002106&fileSn=0",
                            modelNumber = "ZM850ARX850WPlatinum",
                            Price = 260.39M,
                            Brand = "ZALMAN",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 850,
                            Modular = true,
                            Classification = Classification.Platinum
                        },
                        new()
                        {
                            Name = "Seasonic Focus PX ATX 750W 80+ Platinum BOX FOCUS PX 750",
                            Description = "The newly upgraded FOCUS PX and GX series are the successors to the FOCUS PLUS Series," +
                                          " which became an instant top seller in the power supply market after its launch in 2017." +
                                          " In 2019, Seasonic engineers have made improvements to the popular series such as removing" +
                                          " the inline capacitors on the supplied cables. Besides the small change in the series naming," +
                                          " the PSU housing and its packaging are also updated to be in line with the concept of the" +
                                          " OneSeasonic Initiative",
                            productOfficialWebsite = "https://seasonic.com/focus-px",
                            mainImage = "https://seasonic.com/pub/media/wysiwyg/feature-pics/FOCUS-PX-feature.png",
                            modelNumber = "FOCUS-PX-750",
                            Price = 190.39M,
                            Brand = "Seasonic",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 1600,
                            Modular = true,
                            Classification = Classification.Platinum
                        },
                        new()
                        {
                            Name = "Corsair RMx White 750W 80+ Gold",
                            Description = "CORSAIR RMx White Series fully modular power supplies are built with the highest quality components to deliver 80 PLUS Gold power to your PC, with virtually silent operation",
                            productOfficialWebsite = "https://www.corsair.com/us/en/Categories/Products/Power-Supply-Units/Power-Supply-Units-Advanced/RMx-Series-White/p/CP-9020187-NA",
                            mainImage = "https://3.pcx.hu/pcx_upload/termek-kepek/82/m/82219_1.jpg",
                            modelNumber = "CP-9020187-EU",
                            Price = 185.39M,
                            Brand = "Corsair",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 750,
                            Modular = true,
                            Classification = Classification.Gold
                        },
                        new()
                        {
                            Name = "Thermaltake Toughpower PF1 ATX 850W 80+ Platinum BOX",
                            Description = "80 PLUS Platinum certified fully modular PSU with Hydraulic Bearing fan",
                            productOfficialWebsite = "https://www.thermaltake.com/toughpower-pf1-850w-tt-premium-edition.html",
                            mainImage = "https://3.pcx.hu/pcx_upload/termek-kepek/80/b/807107_1.jpg",
                            modelNumber = "PS-TPD-0850FNFAPE-1",
                            Price = 180.39M,
                            Brand = "Thermaltake",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 850,
                            Modular = true,
                            Classification = Classification.Platinum
                        },
                        new()
                        {
                            Name = "FSP 700W 80+ Hyper Pro OEM",
                            Description = "The new HYPER K PRO PSUs comply fully ATX12 v2.52 standard and latest safety" +
                                          " 62368 regulation as well, and features with all black and high-grade ribbon cables," +
                                          " will give your PC a polished look. The HYPER K PRO series is characterized by a powerful" +
                                          " single +12V rail design that continually delivers maximum performance for the most demanding" +
                                          " components, while FSP’s custom DC-DC design provides safety and power efficiency. With an" +
                                          " 230V 80 Plus™ rating, both models deliver over 85% high efficiency and low noise levels thanks" +
                                          " to its 120mm hydraulic bearing (HYB) fan takes care of cooling duties when required, making it" +
                                          " excellent for situations that are sensitive to size and noise",
                            productOfficialWebsite = "https://www.fsplifestyle.com/en/product/HYPER_K_PRO700W.html",
                            mainImage = "https://www.fsplifestyle.com/upload/product/PIC20300000000007753.jpg",
                            modelNumber = "9PA7008801",
                            Price = 70.39M,
                            Brand = "FSP",
                            Warranty = 3,
                            Rating = 5,
                            Capacity = 1600,
                            Modular = false,
                            Classification = Classification.Gold
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
                            Name = "CORSAIR Vengeance LPX Black DDR4, 4000MHz 32GB (2 x 16GB) memory",
                            Description = "4000MHz 32GB (2 x 16GB) memory CMK32GX4M2F4000C19",
                            productOfficialWebsite = "https://www.corsair.com/us/en/Categories/Products/Memory/VENGEANCE-LPX/p/CMK32GX4M2G4000C19",
                            mainImage = "https://www.corsair.com/us/en/medias/sys_master/images/images/hbc/h39/9650694783006/CMK32GX4M2G4000C19/Gallery/VENG_LPX_BLK_01/-CMK32GX4M2G4000C19-Gallery-VENG-LPX-BLK-01.png_1200Wx1200H",
                            modelNumber = "CMK32GX4M2F4000C19",
                            Price = 376.79M,
                            Brand = "Corsair",
                            Warranty = 10,
                            Rating = 5,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 4000,
                            Latency = 12,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "G.Skill Trident Z Neo CL14 (2x16GB)",
                            Description = "Engineered and optimized for full compatibility on the latest AMD Ryzen platforms, " +
                                          "Trident Z Neo brings unparalleled DRAM memory performance and vibrant RGB lighting " +
                                          "to any gaming PC or workstation with latest AMD Ryzen CPUs and AMD DDR4 motherboards.",
                            productOfficialWebsite = "https://www.gskill.com/product/165/326/1620977070/F4-3600C14D-32GTZNA",
                            mainImage = "https://www.gskill.com/_upload/images/162097707010.png",
                            modelNumber = "F4-3600C14D-32GTZN",
                            Price = 316.79M,
                            Brand = "G.Skill",
                            Warranty = 10,
                            Rating = 5,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 14,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "Corsair Vengeance RGB PRO CL18 KIT2 ",
                            Description = "CORSAIR VENGEANCE RGB PRO Series DDR4 overclocked memory lights up your PC with mesmerizing dynamic multi-zone RGB " +
                                          "lighting, while delivering the best in DDR4 performance.CMK32GX4M2F4000C19",
                            productOfficialWebsite = "https://www.corsair.com/us/en/Categories/Products/Memory/Vengeance-PRO-RGB-Black/p/CMW64GX4M2D3600C18",
                            mainImage = "https://www.corsair.com/us/en/medias/sys_master/images/images/hb4/he1/9568426098718/CMW64GX4M2K4000C18/Gallery/Vengeance_RGB_Pro_01/-CMW64GX4M2K4000C18-Gallery-Vengeance-RGB-Pro-01.png_1200Wx1200H",
                            modelNumber = "CMW64GX4M2D3600C18",
                            Price = 300.79M,
                            Brand = "Corsair",
                            Warranty = 10,
                            Rating = 5,
                            Size = 64,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 18,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "Patriot DDR4 3000MHz 64GB (2x32GB) Viper 4 Blackout Dual Channel CL16 1,35V",
                            Description = "Patriot Viper 4 Blackout Series memory modules are designed with both true performance and" +
                                          " sleek style in  mind. Built for the latest  matches perfectly with almost any PC build" +
                                          " Edition Series provides top quality performance and platforms, the Viper 4 Blackout",
                            productOfficialWebsite = "https://viper.patriotmemory.com/products/viper-4-blackout-ddr4-performance-memory-ram-viper-gaming-by-patriot-memory",
                            mainImage = "https://1.pcx.hu/pcx_upload/termek-kepek/88/b/883711_1.jpg",
                            modelNumber = "PVB464G300C6K",
                            Price = 215.79M,
                            Brand = "Corsair",
                            Warranty = 10,
                            Rating = 5,
                            Size = 64,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 16,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "Thermaltake Toughram XG RGB 2x16GB DDR4 3600MHz",
                            Description = "4000MHz 32GB (2 x 16GB) memory CMK32GX4M2F4000C19",
                            productOfficialWebsite = "https://www.thermaltake.com/toughram-xg-rgb-memory-ddr4-3600mhz-32gb-kit-16g-x2-white.html",
                            mainImage = "https://www.thermaltake.com/media/catalog/product/cache/6af153fd0a0c509bdfcdfb60a394dd9c/t/o/toughram_xg_rgb_memory_white_1_4.jpg",
                            modelNumber = "RG06D416GX2-3600C18B",
                            Price = 376.79M,
                            Brand = "Thermaltake",
                            Warranty = 10,
                            Rating = 5,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 18,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "Team Group T-Force XTREEM ARGB White ",
                            Description = "A white and flawless morning star Full-screen light penetrating design keeps it colorful and translucent" +
                                          " Premium overclocking 10-layer board Superior performance and capacity upgrade Selected high quality IC that" +
                                          " is stable and reliable Support O.C. Profile for one click overclocking Support multiple lighting control software",
                            productOfficialWebsite = "https://www.teamgroupinc.com/en/product/xtreem-argb-white-ddr4",
                            mainImage = "https://www.teamgroupinc.com/en/upload/product_color_m/92eb10a8e81ab49f4bf3b5aab005bc73-20210126171008.jpg",
                            modelNumber = "TF13D432G3600HC18JDC01",
                            Price = 85.79M,
                            Brand = "Team Group",
                            Warranty = 10,
                            Rating = 5,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 18,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "CORSAIR Vengeance RGB RS DDR4. 3600MHz 32GB (4x8GB) ",
                            Description = "CORSAIR VENGEANCE RGB RS DDR4 memory punches up your PC’s aesthetics with dynamic, individually addressable" +
                                          " RGB lighting, while delivering outstanding performance optimized for Intel® and AMD motherboards",
                            productOfficialWebsite = "https://www.corsair.com/us/en/Categories/Products/Memory/VENGEANCE-RGB-RS/p/CMG32GX4M4D3600C18",
                            mainImage = "https://www.corsair.com/us/en/medias/sys_master/images/images/h32/hb2/9838239023134/CMG32GX4M4D3600C18/Gallery/VENGEANCE_RGB_RS_01/-CMG32GX4M4D3600C18-Gallery-VENGEANCE-RGB-RS-01.png_515Wx515H",
                            modelNumber = "CMG32GX4M4D3600C18",
                            Price = 80.79M,
                            Brand = "Corsair",
                            Warranty = 10,
                            Rating = 5,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 18,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "SILICON POWER XPOWER Zenith DDR4 3600MHz DIMM CL18 1.35V 32GB Kit2 ",
                            Description = "Optimized For Hardcore Gamers And Modders Ranging from blazing speeds of 3200MHz to 4133MHz " +
                                          "with low 1.35V – 1.4V power consumption, the Zenith allows for gameplay at the highest settings " +
                                          "with automatic overclocking. Its fully optimized testing ensures complete compatibility on most " +
                                          "leading high-end motherboards to support the most hardcore gamers and modders.",
                            productOfficialWebsite = "https://www.silicon-power.com/web/us/product-Zenith_DDR4_Gaming_UDIMM",
                            mainImage = "https://www.silicon-power.com/images/product/apple/518/Zenith_spec_ph.jpg",
                            modelNumber = "SP032GXLZU360BDC",
                            Price = 376.79M,
                            Brand = "SILICON POWER",
                            Warranty = 10,
                            Rating = 5,
                            Size = 32,
                            MemoryType = "DDR4",
                            Frequency = 3600,
                            Latency = 18,
                            HeatSink = true
                        },
                        new()
                        {
                            Name = "Corsair Dominator Platinum RGB White 2X8GB 4000Mhz DDR4",
                            Description = "CORSAIR DOMINATOR® PLATINUM RGB DDR4 Memory redefines premium DDR4 memory, with superior aluminum craftsmanship, " +
                                          "tightly screened high-frequency memory chips and 12 ultra-bright, individually addressable CAPELLIX RGB LEDs",
                            productOfficialWebsite = "https://www.corsair.com/us/en/Categories/Products/Memory/DOMINATOR-PLATINUM-RGB/p/CMT16GX4M2K4000C19W",
                            mainImage = "https://www.corsair.com/us/en/medias/sys_master/images/images/h51/h23/9506492252190/CMT16GX4M2K4000C19W/Gallery/DOMINATOR_PLAT_RGB_WHITE_01/-CMT16GX4M2K4000C19W-Gallery-DOMINATOR-PLAT-RGB-WHITE-01.png_515Wx515H",
                            modelNumber = "CMT16GX4M2K4000C19W",
                            Price = 12.79M,
                            Brand = "Corsair",
                            Warranty = 10,
                            Rating = 5,
                            Size = 4,
                            MemoryType = "DDR4",
                            Frequency = 2666,
                            Latency = 19,
                            HeatSink = false
                        },
                        new()
                        {
                            Name = "GOODRAM DDR4 4GB 2666MHz CL19 SR DIMM GR2666D464L19S/4G",
                            Description = "DDR4 memory modules are a great solution for PCs. The DDR4 generation is the most popular " +
                                          "format in the family of memory modules chosen by users today",
                            productOfficialWebsite = "https://www.goodram.com/en/products/dram-ddr4-dimm-2/",
                            mainImage = "https://www.goodram.com/wp-content/uploads/www-1920-v2-_0013__dram-pet-ddr4-dimm-1-1920x960.jpg",
                            modelNumber = "CMK32GX4M2F4000C19",
                            Price = 15.79M,
                            Brand = "GOODRAM",
                            Warranty = 10,
                            Rating = 5,
                            Size = 4,
                            MemoryType = "DDR4",
                            Frequency = 3200,
                            Latency = 19,
                            HeatSink = false
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}