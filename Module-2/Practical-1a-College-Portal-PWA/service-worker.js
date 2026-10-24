const CACHE_NAME = "college-portal-v1";

const ASSETS = [
    "/",
    "/style.css",
    "/manifest.json"
];

self.addEventListener("install", event => {
    console.log("Service Worker: Installing...");

    event.waitUntil(
        caches.open(CACHE_NAME)
            .then(cache => {
                return cache.addAll(ASSETS);
            })
    );
});

self.addEventListener("activate", event => {
    console.log("Service Worker: Activated");
});

self.addEventListener("fetch", event => {
    event.respondWith(
        caches.match(event.request)
            .then(response => {
                return response || fetch(event.request);
            })
    );
});
