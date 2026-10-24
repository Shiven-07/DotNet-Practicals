// Service Worker: push event handler
// (in service-worker.js)
self.addEventListener('push', event => {
const data = event.data ? event.data.json() : {};
const options = {
body: data.body || 'New notification!',

icon: '/icons/icon-192x192.png',
badge: '/icons/badge.png',
vibrate: [200, 100, 200]
};
event.waitUntil(
self.registration.showNotification(data.title || 'MyApp', options)
);
});
