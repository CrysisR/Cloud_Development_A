var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*
 * Sources
 * Cloud image - https://www.freepik.com/free-photos-vectors/cartoon-cloud
 * Children images - https://www.alamy.com/ethiopia-amhara-region-gondar-wolleka-falasha-jewish-village-children-selling-souvenirs-to-senior-tourist-image335748945.html?imageid=B02E46E5-F56C-4D36-9C12-8CAB265E8FB5&p=72320&pn=1&searchId=09c23d487f63372d037b4398389faf4f&searchtype=0
 * charcoal drawing- https://triciareust.com.au/charcoal-on-canvas/
 * grade 11 student - https://irmasternmuseum.co.za/grade-11-learners-exhibit-at-museum/
 * art festival - https://www.citizen.co.za/alex-news/news-headlines/local-school-news/2022/11/16/school-art-festival-to-expand-to-other-schools/
 * https://www.citizen.co.za/south-coast-sun/news-headlines/2019/09/13/local-high-schools-exhibit-their-art/
 */
